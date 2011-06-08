﻿namespace DW.Commerce.Rest.Infrastructure.NHibernateMaps.Conventions
{
    #region Using Directives

    using FluentNHibernate.Conventions;

    #endregion

    public class PrimaryKeyConvention : IIdConvention
    {
        public void Apply(FluentNHibernate.Conventions.Instances.IIdentityInstance instance)
        {
            instance.Column( "Id");
        }
    }
}