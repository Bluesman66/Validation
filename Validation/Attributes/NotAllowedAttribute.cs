using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Validation.Models;

namespace Validation.Attributes
{
	public class NotAllowedAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			Book b = value as Book;
			if (b.Name == "Преступление и наказание" && b.Author == "Ф. Достоевский" && b.Year == 1866)
			{
				return false;
			}
			return true;
		}
	}
}