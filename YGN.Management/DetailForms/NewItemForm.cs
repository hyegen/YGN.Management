﻿using Commons.Enums;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using Entities.Concrete;
using YGN.BusinessLayer.FluentValidation;
using FluentValidation.Results;

namespace YGN.Management.DetailForms
{
    public partial class NewItemForm : XtraForm
    {
        #region members

        ItemManager itemManager = new ItemManager(new EfItemDal());
        StringBuilder stringBuilder = new StringBuilder();

        #endregion

        #region constructor
        public NewItemForm()
        {
            InitializeComponent();
        }

        #endregion

        #region properties

        public string ItemCode
        {
            get { return itemCodeTextEdit?.Text; }
            set { itemCodeTextEdit.Text = value; }
        }

        public string ItemName
        {
            get { return itemNameTextEdit?.Text; }
            set { itemNameTextEdit.Text = value; }
        }

        public double? UnitPrice
        {
            get
            {
                if (double.TryParse(unitPriceTextEdit?.Text, out double result))
                {
                    return result;
                }
                return null;
            }
            set { unitPriceTextEdit.Text = value?.ToString(); }
        }

        public string Category
        {
            get { return categoryComboBoxEdit?.Text; }
            set { categoryComboBoxEdit.Text = value?.ToString(); }
        }

        #endregion

        #region events
        private void saveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newItem = new Item
            {
                ItemCode = ItemCode,
                ItemName = ItemName,
                UnitPrice = UnitPrice,
                Category1 = Category
            };
            ItemValidator itemValidator = new ItemValidator();
            ValidationResult result = itemValidator.Validate(newItem);
            if (result.IsValid)
            {
                itemManager.AddItem(newItem);
                XtraMessageBox.Show(string.Format("{0} kodlu, {1} adlı kayıt başarıyla eklenmiştir.", newItem.ItemCode, newItem.ItemName),"Bilgi");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    stringBuilder.AppendLine(item.ErrorMessage);
                }
                XtraMessageBox.Show(stringBuilder.ToString(),"Error");
                Close();
            }

        }

        private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        #endregion

        #region methods
        public void addToTransaction()
        {
            //int lastItemId = dbcontext.ITEMS.OrderByDescending(x => x.ID).Select(x => x.ID).FirstOrDefault();

            //TRANSACTIONS transaction = new TRANSACTIONS
            //{
            //    TRCODE = (int)Trcode.Input,
            //    PROCESSDATE = DateTime.Now,
            //    ITEMID = lastItemId,
            //    USERID = GlobalVariables.USERID,
            //    AMOUNT = Amount
            //};

            //dbcontext.TRANSACTIONS.Add(transaction);
            //dbcontext.SaveChanges();
        }

        #endregion
    }
}