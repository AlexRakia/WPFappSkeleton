using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmSkeleton.Models;

namespace WpfMvvmSkeleton
{
		// Tip: define an interface (ISampleService) and inject it into the
		// ViewModel constructor — that makes unit-testing trivial because
		// you can swap in a fake implementation.

		public interface ISampleService
		{
				Task<List<SampleItem>> GetItemsAsync();
				Task<bool> SaveItemAsync(SampleItem item);
				Task<bool> DeleteItemAsync(int id);
		}
}
