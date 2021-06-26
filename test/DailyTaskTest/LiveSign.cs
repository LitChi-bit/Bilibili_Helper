using System;
using Microsoft.Extensions.DependencyInjection;
using Ray.BiliBiliTool.Console;
using Ray.BiliBiliTool.DomainService.Interfaces;
using Ray.BiliBiliTool.Infrastructure;
using Xunit;

namespace DailyTaskTest
{
    public class LiveSign
    {
        [Fact]
        public void Test1()
        {
            Program.CreateHost(new string[] { });

            using (var scope = Global.ServiceProviderRoot.CreateScope())
            {
                var dailyTask = scope.ServiceProvider.GetRequiredService<ILiveDomainService>();

                dailyTask.LiveSign();

                Assert.True(true);
            }
        }
    }
}
