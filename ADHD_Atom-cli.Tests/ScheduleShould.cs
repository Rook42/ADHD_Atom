using Xunit;

namespace ADHD_Atom_cli.Tests
{

    public class ScheduleShould
    {
        [Fact]
        public void Add_a_task()
        {
            //TODO: Task mocking so this is expressive
            var schedule = new Schedule();
            schedule.AddTask("task1", "task1");
            Assert.Equal(1, schedule.Tasks.Count);
        }

        [Fact]
    }

    [Fact]
    public void Remove_a_task()
    {

    }

    [Fact]
    public void Get_a_task()
    {

    }
}
}

