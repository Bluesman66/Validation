using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Validation.Models
{
	public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
	{
		protected override void Seed(BookContext context)
		{
			context.Books.Add(new Book { Id = 1, Name = "Война и мир", Author = "Л. Толстой", Year = 1869 });
			context.Books.Add(new Book { Id = 2, Name = "Отцы и дети", Author = "И. Тургенев", Year = 1862 });
			context.Books.Add(new Book { Id = 3, Name = "Чайка", Author = "А. Чехов", Year = 1896 });

			base.Seed(context);
		}
	}
}