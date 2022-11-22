﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Validations
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is IFormFile file)
            {
                if(file.Length > _maxFileSize)
                {
                    return new ValidationResult($"Maximum allowed file size is {_maxFileSize} bytes");
                }
            }
            return ValidationResult.Success;
        }
    }
}
