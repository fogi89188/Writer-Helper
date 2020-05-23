﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Writer_Helper.ViewModels
{
    /// <summary>
    /// the view model for a custom window
    /// </summary>
    class WindowViewModel : BaseViewModel
    {

        #region Private Member
        /// <summary>
        /// the window this view model controls
        /// </summary>
        private Window mWindow;
        /// <summary>
        /// the margin around the window to allow for a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;
        /// <summary>
        /// the radius of the edges of the window
        /// </summary>
        private int mWindowRadius = 10;
        #endregion

        #region Public Properties

        /// <summary>
        /// the size of the resize boreder around the window
        /// </summary>
        public int ResizeBorder { get; set; } = 6;
        /// <summary>
        /// the size of the resize border around the window
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); }}

        /// <summary>
        /// the margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }

        /// <summary>
        /// the margin around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// the radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }

        /// <summary>
        /// the radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// The height of the title bar caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 30;

        #endregion

        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            //listen out for the window resizing
            mWindow.StateChanged += (sender, e) =>
            {
                //fire off event for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
        }
        #endregion
    }
}