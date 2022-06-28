using DevExpress.Data;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace DXGrid_DisplayTotals {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = AccountList.GetData();
        }
        // Define total summaries in code:
        void CreateTotalSummaries() {
            grid.TotalSummary.AddRange(new List<GridSummaryItem>() {
                new GridSummaryItem() {
                    SummaryType = SummaryItemType.Count,
                    Alignment = GridSummaryItemAlignment.Left,
                    DisplayFormat = "Total Users: {0}"
                },
                new GridSummaryItem() {
                    FieldName = "Age",
                    SummaryType = SummaryItemType.Min
                },
                new GridSummaryItem() {
                    FieldName = "Age",
                    SummaryType = SummaryItemType.Max
                }
            });
        }
    }
    public class AccountList {
        public static ObservableCollection<Account> GetData() {
            ObservableCollection<Account> list = new ObservableCollection<Account>();
            list.Add(new Account() {
                UserName = "Nick White",
                RegistrationDate = DateTime.Today,
                Married = true,
                Age = 42
            });
            list.Add(new Account() {
                UserName = "Jack Rodman",
                RegistrationDate = new DateTime(2009, 5, 10),
                Married = false,
                Age = 30
            });
            list.Add(new Account() {
                UserName = "Sandra Sherry",
                RegistrationDate = new DateTime(2008, 12, 22),
                Married = false,
                Age = 18
            });
            list.Add(new Account() {
                UserName = "Sabrina Vilk",
                RegistrationDate = DateTime.Today,
                Married = true,
                Age = 24
            });
            list.Add(new Account() {
                UserName = "Mike Pearson",
                RegistrationDate = new DateTime(2008, 10, 18),
                Married = true,
                Age = 37
            });
            return list;
        }
    }
    public class Account {
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Married { get; set; }
        public int Age { get; set; }
    }
}
