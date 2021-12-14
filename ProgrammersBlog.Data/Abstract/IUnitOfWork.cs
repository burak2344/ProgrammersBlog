using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
	public interface IUnitOfWork:IAsyncDisposable
	{
		//Burada Tüm Repositoryleri tek merkezden yöneteceğiz.
		IArticleRepository Articles { get; }
		ICommentRepository Comments { get; }
		ICategoryRepository Categories { get; } //_unitOfWork.Categories.AddAsync();




		//_unitOfWork.Categories.AddAsync(category);
		//_unitOfWork.User.AddAsync(user);
		//_unitOfWork.SaveAsync();
		Task<int> SaveAsync();

	}
}
