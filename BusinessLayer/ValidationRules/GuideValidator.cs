﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Rehber İsmi Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Rehber resimi boş geçilemez");
        }
    }
}
