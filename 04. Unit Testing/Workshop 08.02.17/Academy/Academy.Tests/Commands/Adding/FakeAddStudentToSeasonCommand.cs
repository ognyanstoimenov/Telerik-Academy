using Academy.Commands.Adding;
using Academy.Core.Contracts;

namespace Academy.Tests.Commands.Adding
{
    internal class FakeAddStudentToSeasonCommand : AddStudentToSeasonCommand
    {
        public FakeAddStudentToSeasonCommand(IAcademyFactory factory, IEngine engine) : base(factory,engine)
        {
            
        }

        internal IAcademyFactory Factory => this.factory;

        internal IEngine Engine => this.engine;

    }
}
