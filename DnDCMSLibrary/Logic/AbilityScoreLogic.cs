﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDCMSLibrary.Repositories;
using DnDCMSLibrary.Entities;
using DnDCMSLibrary.Interfaces;

namespace DnDCMSLibrary.Logic
{
    public class AbilityScoreLogic
    {
        private IAbilityScoreRepository repository = new AbilityScoreContext();

        public AbilityScoreLogic(IAbilityScoreRepository repository)
        {
            this.repository = repository;
        }

        public List<AbilityScore> GetAbilityScores(int id)
        {
            return repository.GetAbilityScores(id);
        }
    }
}
