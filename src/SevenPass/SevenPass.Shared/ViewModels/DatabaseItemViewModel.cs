﻿using System;
using SevenPass.Services.Databases;

namespace SevenPass.ViewModels
{
    /// <summary>
    /// ViewModel to display database details in a list.
    /// </summary>
    public class DatabaseItemViewModel
    {
        /// <summary>
        /// Gets or sets the database ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the database display name.
        /// </summary>
        public string Name { get; set; }
    }
}