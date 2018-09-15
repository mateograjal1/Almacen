using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Logic.DatabaseObjects
{
    public class ObjectFactory
    {
        public static List<Category> createCategoryList(DataTable dt)
        {
            List<Category> list = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr[0];
                string name = (string)dr[1];
                list.Add(new Category(id, name));
            }
            return list;
        }
        public static List<Status> createStatusList(DataTable dt)
        {
            List<Status> list = new List<Status>();
            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr[0];
                string name = (string)dr[1];
                list.Add(new Status(id, name));
            }
            return list;
        }
        public static List<Role> createRoleList(DataTable dt)
        {
            List<Role> list = new List<Role>();
            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr[0];
                string name = (string)dr[1];
                list.Add(new Role(name, id));
            }
            return list;
        }

        public static List<Stock> createStockList(DataTable dt)
        {
            List<Stock> list = new List<Stock>();
            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr[0];
                float amount = (dr[3] != null && !string.IsNullOrEmpty(dr[3].ToString())) ? float.Parse(dr[3].ToString()) : 0.0f;
                list.Add(new Stock(id, amount));
            }
            return list;
        }

    }
}
