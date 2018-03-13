// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using iTechart.Survey.DAL;
using iTechart.Survey.DAL.Interfaces;
using iTechart.Survey.DAL.Context;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.EntityFramework.Repository;
using iTechArt.Repositories.Interfaces;
using iTechArt.Survey.BLL.Interfaces;
using iTechArt.Survey.BLL.Services.UserService;

namespace DependencyResolution.DependencyResolution
{
    using iTechArt.Survey.DomainModel;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;

    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            For<IRepository<User>>().Use<Repository<User>>();
            For<IDbContext>().Use<SurveyContext>().AlwaysUnique();
            For<IUserService>().Use<UserService>();
            For<ISurveyUnitOfWork>().Use<SurveyUnitOfWork>();
        }
        #endregion
    }
}