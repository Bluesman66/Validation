using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Attributes;

namespace Validation.Models
{
	[NotAllowedAttribute(ErrorMessage = "Недопустимая книга")]
	public class Book
	{
		[HiddenInput(DisplayValue = false)]
		public int Id { get; set; }

		[Required(ErrorMessage = "Поле должно быть установлено")]
		[Display(Name = "Название")]
		public string Name { get; set; }

		[Required]
		[MyAuthors(new string[] { "Л. Толстой", "А. Пушкин", "Ф. Достоевский", "И. Тургенев" }, ErrorMessage = "Недопустимый автор")]
		[Display(Name = "Автор")]
		public string Author { get; set; }

		[Required]
		[Display(Name = "Год")]
		[Range(1700, 2000, ErrorMessage = "Недопустимый год")]
		public int Year { get; set; }
	}
}