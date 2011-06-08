﻿namespace DW.Commerce.Rest.Infrastructure.NHibernateMaps.Conventions
{
    #region Using Directives

    using FluentNHibernate.Conventions;

    #endregion

    public class TableNameConvention : IClassConvention
    {
        public void Apply(FluentNHibernate.Conventions.Instances.IClassInstance instance)
        {
            instance.Table(Inflector.Net.Inflector.Pluralize(instance.EntityType.Name));

        }
    }
}