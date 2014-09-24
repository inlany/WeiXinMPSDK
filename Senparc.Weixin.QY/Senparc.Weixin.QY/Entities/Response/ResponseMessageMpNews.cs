﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.QY.Entities
{
    public class ResponseMessageMpNews : ResponseMessageBase, IResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.MpNews; }
        }

        public int MpNewsArticleCount
        {
            get { return (MpNewsArticles ?? new List<MpNewsArticle>()).Count; }
            set
            {
                //这里开放set只为了逆向从Response的Xml转成实体的操作一致性，没有实际意义。
            }
        }

        /// <summary>
        /// 文章列表，微信客户端只能输出前10条（可能未来数字会有变化，出于视觉效果考虑，建议控制在8条以内）
        /// </summary>
        public List<MpNewsArticle> MpNewsArticles { get; set; }

        public ResponseMessageMpNews()
        {
            MpNewsArticles = new List<MpNewsArticle>();
        }
    }
}
