using Linq.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq.Logica
{
    public class UserData
    {
        DataUsersDataContext user = new DataUsersDataContext();
        Users obj = new Users();
        Infor i = new Infor();
        public void usuario(ListView list, ListView list2,string valor)
        {
            var query = from u in user.Users join i in user.Infor 
                        on u.IdUser equals i.IdUsers where u.Name.StartsWith(valor)
                        select new {
                            u.IdUser,
                            u.Name,
                            u.Age,
                            i.Info
                        };
            var datos = query.ToList();
            foreach(var Data in datos)
            {
                ListViewItem item = new ListViewItem(Data.IdUser.ToString());
                ListViewItem item2 = new ListViewItem(Data.Info);
                item.SubItems.Add(Data.Name);
                item.SubItems.Add(Data.Age.ToString());
                list.Items.Add(item);
                list2.Items.Add(item2);
            }
        }

        public bool insertar(TextBox textBox1,TextBox textBox2, TextBox textBox3)
        {
            int id = 0;
            obj.Name = textBox1.Text;
            obj.Age = Convert.ToInt32(textBox2.Text);
            user.Users.InsertOnSubmit(obj);
            user.SubmitChanges();
            i.Info = textBox3.Text;
            var query=from u in user.Users select u;
            var datos = query.ToList();
            foreach (var Data in datos)
            {
                id = Data.IdUser;
            }
            i.IdUsers = id;
            user.Infor.InsertOnSubmit(i);
            user.SubmitChanges();
            return true;
        }

        public bool update(TextBox textBox1, TextBox textBox2, TextBox textBox3, int id)
        {
            obj = user.Users.Where(x=>x.IdUser==id).Single<Users>();
            obj.Name = textBox1.Text;
            obj.Age = Convert.ToInt32(textBox2.Text);
            i = user.Infor.Where(x => x.IdUsers == id).Single<Infor>();
            i.Info = textBox3.Text;
            user.SubmitChanges();

            return true;
        }

        public bool delete(int id)
        {
            i = user.Infor.Where(x => x.IdUsers == id).Single<Infor>();
            user.Infor.DeleteOnSubmit(i);
            obj = user.Users.Where(x=>x.IdUser==id).Single<Users>();
            user.Users.DeleteOnSubmit(obj);
            user.SubmitChanges();
            return true;
        }

        public void consult(TextBox textBox4, int id)
        {
            var query = from num in user.Infor
                        where num.IdUsers == id
                        select num;
            var datos = query.ToList();
            foreach (var Data in datos)
            {
                textBox4.Text = Data.Info;
            }
        }
    }
}
