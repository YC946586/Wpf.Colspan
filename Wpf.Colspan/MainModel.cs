using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Colspan
{
    public class MainModel
    {
        public IList<Child> NumberNodes { get; set; } = new List<Child>();

        public List<Child> SelectNodes { get; set; } = new List<Child>();

        public List<Child> DateNodes { get; set; }

        public List<Child> VoucherWordNodes { get; set; } = new List<Child>();

        public string SourceType { get; set; }

        public long VoucherMoney { get; set; }

        public string Auditor { get; set; }
    }

    public class Child : ViewModelBase
    {
        public string word { get; set; }

        public bool _isSelect;
        /// <summary>
        /// 选中
        /// </summary>
        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; RaisePropertyChanged(); }
        }
    }
}
