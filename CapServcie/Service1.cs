using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using CapServcie.SqlOption;
using mfg_word_Dal;

namespace CapServcie
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
       
       

        //开始
        protected override void OnStart(string[] args)
        {

            //执行的方法和多长时间执行一次
            System.Threading.Timer timer2 = new System.Threading.Timer(Docap, null, 0, 1000 * 6);//6秒执行一次
        }


        /// <summary>
        /// 进行也去操作
        /// </summary>
        /// <param name="state"></param>
        private static void Docap(object state)
        {

            string sql = string.Format("UPDATE   MomentFun  SET  Mark={0}  WHERE  id=1",DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            DBHelper.ExecSql(sql);


        }


        //结束
        protected override void OnStop()
        {
        }
    }
}
