﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using KiwiCrawler.Model;
namespace KiwiCrawler.BLL
{
	/// <summary>
	/// Urlconfigs_kBll
	/// </summary>
	public partial class Urlconfigs_kBll
	{
		private readonly KiwiCrawler.DAL.Urlconfigs_kDal dal=new KiwiCrawler.DAL.Urlconfigs_kDal();
		public Urlconfigs_kBll()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int kId)
		{
			return dal.Exists(kId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(KiwiCrawler.Model.Urlconfigs_k model)
		{
			return dal.Add(model);
		}      

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(KiwiCrawler.Model.Urlconfigs_k model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int kId)
		{
			
			return dal.Delete(kId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string kIdlist )
		{
			return dal.DeleteList(kIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public KiwiCrawler.Model.Urlconfigs_k GetModel(int kId)
		{
			
			return dal.GetModel(kId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public KiwiCrawler.Model.Urlconfigs_k GetModelByCache(int kId)
		{
			
			string CacheKey = "Urlconfigs_kModel-" + kId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(kId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (KiwiCrawler.Model.Urlconfigs_k)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KiwiCrawler.Model.Urlconfigs_k> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<KiwiCrawler.Model.Urlconfigs_k> DataTableToList(DataTable dt)
		{
			List<KiwiCrawler.Model.Urlconfigs_k> modelList = new List<KiwiCrawler.Model.Urlconfigs_k>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				KiwiCrawler.Model.Urlconfigs_k model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 添加一条信息，返回添加数据的主键
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddBringId(KiwiCrawler.Model.Urlconfigs_k model)
        {
            return dal.AddBringId(model);
        }
        #endregion  ExtensionMethod
    }
}

