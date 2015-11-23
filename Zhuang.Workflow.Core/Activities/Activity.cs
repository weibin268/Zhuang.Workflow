using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhuang.Workflow.Core.Activities
{
    public abstract class Activity
    {
        protected abstract void Execute(ActivityContext context);
    }
}
