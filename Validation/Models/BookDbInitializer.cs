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
			context.Books.Add(new Book { Id = 1, Name = "Война и мир", Author = "Л. Толстой", Year = 1991 });
			context.Books.Add(new Book { Id = 2, Name = "Отцы и дети", Author = "И. Тургенев", Year = 2000 });
			context.Books.Add(new Book { Id = 3, Name = "Чайка", Author = "А. Чехов", Year = 2016 });

			base.Seed(context);
		}
	}
}