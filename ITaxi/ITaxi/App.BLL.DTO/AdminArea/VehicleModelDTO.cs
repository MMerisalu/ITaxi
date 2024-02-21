﻿using System.ComponentModel.DataAnnotations;
using Base.Domain;
using Base.Resources;

namespace App.BLL.DTO.AdminArea;

public class VehicleModelDTO : DomainEntityMetaId
{
    [Required(ErrorMessageResourceType = typeof(Common), ErrorMessageResourceName = "RequiredAttributeErrorMessage")]
    [MaxLength(50, ErrorMessageResourceType = typeof(Common), ErrorMessageResourceName = "ErrorMessageStringLengthMax")]
    [StringLength(50, MinimumLength = 1, ErrorMessageResourceType = typeof(Common),
        ErrorMessageResourceName = "StringLengthAttributeErrorMessage")]
    [Display(ResourceType = typeof(Resources.Areas.App.Domain.AdminArea.VehicleModel), Name = nameof(VehicleModelName))]
    public string VehicleModelName { get; set; } = default!;

    [Display(ResourceType = typeof(Resources.Areas.App.Domain.AdminArea.VehicleModel), Name = "VehicleMarkName")]
    public Guid VehicleMarkId { get; set; }

    [Display(ResourceType = typeof(Resources.Areas.App.Domain.AdminArea.VehicleModel), Name = "VehicleMarkName")]
    public VehicleMarkDTO? VehicleMark { get; set; }
}