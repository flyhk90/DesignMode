using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignCreate
{
    public class Covariant
    {

        /// <summary>
        /// 协变_逆变_不变
        /// </summary>
        public void Test()
        {
            //协变 输出参数，子类当作父类返回。
            IEnumerable<string> list = new List<string>() { "1", "2", "3" };
            IEnumerable<object> list2 = list;

            //不变
            //IList<string> list3 = new List<string>() { "1", "2" };
            //IList<object> list4 = (IList<object>)list3;
            //list4.Add(new object());
            //Console.WriteLine(list4[2]);

            //逆变 输入参数，父类转成子类传入
            Action<object> objectAction = (obj) => Console.WriteLine(obj);
            Action<string> stringAction = objectAction;
            stringAction("string");


            //  ArrayList  1：数据类型不安全，比如计算。2：效率偏低，有装箱操作
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("何康");
            //int test = (int)al[1];
            //Console.WriteLine(test);
        }
    }
}
