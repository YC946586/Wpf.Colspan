using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace Wpf.Colspan
{
    public class MainVIewModel : ViewModelBase
    {

        private ObservableCollection<MainModel> _dtaaList = new ObservableCollection<MainModel>();

        public ObservableCollection<MainModel> DataList
        {
            get => _dtaaList;
            set
            {
                _dtaaList = value;
                RaisePropertyChanged();
            }
        }
        public void InitUi()
        {
            try
            {
                var curModel = Readjson();
                var propertyInfos = typeof(MainModel).GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
                MainModel mainModel = new MainModel();
                foreach (var link in curModel.links)
                {
                    var property = propertyInfos.FirstOrDefault(s => s.Name.Equals(link.name));
                    if (link.dataList!= null && link.dataList.Count!=0)
                    {
                        property.SetValue(mainModel, link.dataList);
                    }
                    else
                    {
                        property.SetValue(mainModel, link.data);
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    DataList.Add(mainModel);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static JsonEntity Readjson()
        {
            string jsonfile = AppDomain.CurrentDomain.BaseDirectory + "jsconfig.json";
            using (StreamReader sr = File.OpenText(jsonfile))
            {
                string json = sr.ReadToEnd();
                JsonEntity list = JsonConvert.DeserializeObject<JsonEntity>(json);
                sr.Close();
                sr.Dispose();
                return list;
            }
        }
    }
}
