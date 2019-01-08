﻿using BanFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanFramework.Core.Aspects.PostSharp
{
    [Serializable]// aspectlerde şart serileştirimiş olmalı
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        private readonly Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            if (_validatorType.BaseType != null)
            {
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = args.Arguments.Where(t => t.GetType() == entityType);

                foreach (var entity in entities)
                {
                    ValidatorTool.FluentValidate(validator, entity);
                }
            }
        }   
    }
}

