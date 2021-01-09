﻿using SmartStore.Web.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartStore.Web.Models.Home
{
	public class PlanModel
	{
		public PlanModel()
		{
			AvailableLevels = new List<SelectListItem>();
		}

		public int GridPageSize { get; set; }
		public int PlanId { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.Name")]
		[AllowHtml]
		public string Name { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.PlanDetails")]
		[AllowHtml]
		public string PlanDetails { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.NoOfPayouts")]
		[AllowHtml]
		public int NoOfPayouts { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.Id")]
		public int Id { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.LevelId")]
		public int LevelId { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.Commission")]
		public int Commission { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.ROIPercentage")]
		[AllowHtml]
		public float ROIPercentage { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.MinimumInvestment")]
		[AllowHtml]
		public float MinimumInvestment { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.MaximumInvestment")]
		[AllowHtml]
		public float MaximumInvestment { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.PayEveryXHours")]
		[AllowHtml]
		public int PayEveryXDays { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.PageSize")]
		public int? PageSize { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.PageSizeOptions")]
		public string PageSizeOptions { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.Published")]
		public bool Published { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.Deleted")]
		public bool Deleted { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.DisplayOrder")]
		public int DisplayOrder { get; set; }

		[SmartResourceDisplayName("Common.CreatedOn")]
		public DateTime? CreatedOn { get; set; }

		[SmartResourceDisplayName("Common.UpdatedOn")]
		public DateTime? UpdatedOn { get; set; }

		[SmartResourceDisplayName("Admin.Common.Store.LimitedTo")]
		public bool LimitedToStores { get; set; }

		public IEnumerable<SelectListItem> AvailableStores { get; set; }

		public int[] SelectedStoreIds { get; set; }

		public bool SubjectToAcl { get; set; }

		[SmartResourceDisplayName("Admin.Hyip.Plans.Fields.IsPrincipalBack")]
		public bool IsPrincipalBack { get; set; }

		public IEnumerable<SelectListItem> AvailableCustomerRoles { get; set; }

		public int[] SelectedCustomerRoleIds { get; set; }

		public List<SelectListItem> AvailableLevels { get; set; }
	}
}