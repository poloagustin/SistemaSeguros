﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Project2
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class sistema_seguros_devEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new sistema_seguros_devEntities object using the connection string found in the 'sistema_seguros_devEntities' section of the application configuration file.
        /// </summary>
        public sistema_seguros_devEntities() : base("name=sistema_seguros_devEntities", "sistema_seguros_devEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new sistema_seguros_devEntities object.
        /// </summary>
        public sistema_seguros_devEntities(string connectionString) : base(connectionString, "sistema_seguros_devEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new sistema_seguros_devEntities object.
        /// </summary>
        public sistema_seguros_devEntities(EntityConnection connection) : base(connection, "sistema_seguros_devEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

    
}
