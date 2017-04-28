using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.ActiveRecord;

namespace ZDSoft.LMS.Web
{
    /// <summary>
    /// 用于处理事务操作 castle事务操作
    /// </summary>
    public class CastleWebModule : IHttpModule
    {
        protected static readonly String sessionKey = "nhibernate.session";
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(OnBeginRequest);
            context.EndRequest += new EventHandler(OnEndRequest);
        }

        private void OnBeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Items.Add(sessionKey, new SessionScope(FlushAction.Never));
        }

        private void OnEndRequest(object sender, EventArgs e)
        {
            SessionScope sessionScope = (SessionScope)HttpContext.Current.Items[sessionKey];

            if (sessionScope != null)
            {
                //当有异常发生时，不要提交事务
                if (e == null)
                    sessionScope.Flush();//事务提交
                
                if (sessionScope.WantsToCreateTheSession == false)
                {
                    sessionScope.Dispose();
                }
            }
        }
    }
}