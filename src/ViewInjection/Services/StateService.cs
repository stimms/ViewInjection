using System;
using System.Collections.Generic;
using ViewInjection.Models;

namespace ViewInjection.Services
{
    public interface IStateService
    {
        IEnumerable<State> List();
    }
    public class StateService : IStateService
    {
        public IEnumerable<State> List() {
            return new List<State>
            {
                new State { Abbreviation = "AK", Name = "Alaska" },
                new State { Abbreviation  = "AL", Name = "Alabama" }
            };
        }
    }
}
