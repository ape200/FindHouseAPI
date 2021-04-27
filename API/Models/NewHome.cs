using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API.Models
{
	public class NewHome
	{
		/// <summary>
		/// 主键Id
		/// </summary>
		[Key]
		public int HomeId { get; set; }
		/// <summary>
		/// 房屋名称
		/// </summary>
		public string HomeName { get; set; }
		/// <summary>
		/// 楼房特点
		/// </summary>
		public string HomeCharacteristic { get; set; }
		/// <summary>
		/// 物业类型
		/// </summary>
		public string RealEstate { get; set; }
		/// <summary>
		/// 开发商
		/// </summary>
		public string HomeDevelopers { get; set; }
		/// <summary>
		/// 新房地址
		/// </summary>
		public string HomeAddress { get; set; }
		/// <summary>
		/// 新房户型
		/// </summary>
		public string HomeDesign { get; set; }
		/// <summary>
		/// 新房图片
		/// </summary>
		public string HomeIamge { get; set; }
		/// <summary>
		/// 新房建筑面积
		/// </summary>
		public string HomeArea { get; set; }
		/// <summary>
		/// 新房价格
		/// </summary>
		public decimal HomePrice { get; set; }
		/// <summary>
		/// 新房出售状态
		/// </summary>
		public int HomeMarketType { get; set; }
		/// <summary>
		/// 售楼处电话
		/// </summary>
		public string HomeSalesOffice { get; set; }
	}
}
