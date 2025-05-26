using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primix.Async
{
    public static partial class TaskExtensions
    {
        public static IEnumerable<Task<(int Index, T Result)>> AsCompletedWithIndex<T>(this IEnumerable<Task<T>> tasks)
        {
            var taskList = tasks.Select((t, i) => WrapWithIndex(t, i)).ToList();
            while (taskList.Count > 0)
            {
                var completed = Task.WhenAny(taskList).Result;
                taskList.Remove(completed);
                yield return completed;
            }
        }

        private static async Task<(int, T)> WrapWithIndex<T>(Task<T> task, int index)
            => (index, await task.ConfigureAwait(false));
    }
}
