#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

using System.Collections.ObjectModel;
using Syncfusion.Windows.Shared;

namespace ColumnSizerDemo
{
    public class ViewModel :NotificationObject
    {
        private List<string> _comboBoxItemsSource = new List<string>();

        
        
        private ObservableCollection<OrderInfo> _orderList = new ObservableCollection<OrderInfo>();

        /// <summary>
        /// Gets or sets the order list.
        /// </summary>
        /// <value>The order list.</value>
        public ObservableCollection<OrderInfo> OrderList
        {
            get
            {
                return _orderList;
            }
            set
            {
                _orderList = value;
                RaisePropertyChanged("OrderList");
            }
        }

     

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.PopulateData();
        }

        private bool IsInDesignMode => DesignerProperties.GetIsInDesignMode(new DependencyObject());
        /// <summary>
        /// Populates the data.
        /// </summary>
        private void PopulateData()
        {
            if (!IsInDesignMode)
            {
                Random r = new Random();

                for (int i = 0; i < 150; i++)
                {
                    OrderInfo orderInfo = new OrderInfo();
                    orderInfo.Discount = 12345678954322243.98688457457f;



                    _orderList.Add(orderInfo);
                }
            }
        }
    }
}
