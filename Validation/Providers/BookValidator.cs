using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Models;

namespace Validation.Providers
{
	public class BookValidator : ModelValidator
	{
		public BookValidator(ModelMetadata metadata, ControllerContext context)
			: base(metadata, context)
		{ }

		public override IEnumerable<ModelValidationResult> Validate(object container)
		{
			Book b = (Book)Metadata.Model;

			List<ModelValidationResult> errors = new List<ModelValidationResult>();

			if (b.Name == "Преступление и наказание" && b.Author == "Ф. Достоевский" && b.Year == 1866)
			{
				errors.Add(new ModelValidationResult { MemberName = "", Message = "Недопустимая книга" });
			}
			return errors;
		}
	}
}