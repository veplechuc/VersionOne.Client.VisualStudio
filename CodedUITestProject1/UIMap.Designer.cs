﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinButton uIStartButton = this.UIStartWindow.UIStartButton;
            WinMenuItem uIVisualStudio2013MenuItem = this.UIStartmenuWindow.UIItemWindow.UIStartmenuClient.UIVisualStudio2013MenuItem;
            WpfMenuItem uIVersionOneTasksMenuItem = this.UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIViewMenuItem.UIOtherWindowsMenuItem.UIVersionOneTasksMenuItem;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(17, 24));

            // Click 'Visual Studio 2013' menu item
            Mouse.Click(uIVisualStudio2013MenuItem, new Point(73, 21));

            // Click 'View' -> 'Other Windows' -> 'VersionOne Tasks' menu item
            Mouse.Click(uIVersionOneTasksMenuItem, new Point(67, 7));
        }
        
        /// <summary>
        /// add a new task to the work item
        /// </summary>
        public void addTaskCUI()
        {
            #region Variable Declarations
            WinButton uIStartButton = this.UIStartWindow.UIStartButton;
            WinMenuItem uIVisualStudio2013MenuItem = this.UIStartmenuWindow.UIItemWindow.UIStartmenuClient.UIVisualStudio2013MenuItem;
            WpfMenuItem uIVersionOneTasksMenuItem = this.UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIViewMenuItem.UIOtherWindowsMenuItem.UIVersionOneTasksMenuItem;
            WinClient uITreeViewAdv1Client = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UITreeViewAdv1Window.UITreeViewAdv1Client;
            WinButton uIAddTaskButton = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UITsMenuToolBar.UIAddTaskButton;
            WinEdit uIItemEdit = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UIItemWindow.UIItemEdit;
            WinButton uISaveButton = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UITsMenuToolBar.UISaveButton;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(21, 24));

            // Click 'Visual Studio 2013' menu item
            Mouse.Click(uIVisualStudio2013MenuItem, new Point(77, 15));

            // Click 'View' -> 'Other Windows' -> 'VersionOne Tasks' menu item
            Mouse.Click(uIVersionOneTasksMenuItem, new Point(89, 11));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(62, 31));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(8, 27));

            // Click 'Add Task' button
            Mouse.Click(uIAddTaskButton, new Point(14, 10));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(90, 79));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(92, 75));

            // Type 'new task 2' in text box
            uIItemEdit.Text = this.addTaskCUIParams.UIItemEditText;

            // Type '{Enter}' in text box
            Keyboard.SendKeys(uIItemEdit, this.addTaskCUIParams.UIItemEditSendKeys, ModifierKeys.None);

            // Click 'Save' button
            Mouse.Click(uISaveButton, new Point(13, 10));
        }
        
        /// <summary>
        /// add a new task to the board
        /// </summary>
        public void addTaskName()
        {
            #region Variable Declarations
            WinButton uIStartButton = this.UIStartWindow.UIStartButton;
            WinMenuItem uIVisualStudio2013MenuItem = this.UIStartmenuWindow.UIItemWindow.UIStartmenuClient.UIVisualStudio2013MenuItem;
            WpfMenuItem uIVersionOneTasksMenuItem = this.UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIViewMenuItem.UIOtherWindowsMenuItem.UIVersionOneTasksMenuItem;
            WinClient uITreeViewAdv1Client = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UITreeViewAdv1Window.UITreeViewAdv1Client;
            WinButton uIAddTaskButton = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UITsMenuToolBar.UIAddTaskButton;
            WinEdit uIItemEdit = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UIItemWindow.UIItemEdit;
            WinButton uISaveButton = this.UIMicrosoftVisualStudiWindow.UIVersionOneWorkitemsSPane.UIVersionOneWorkitemsSPane1.UITsMenuToolBar.UISaveButton;
            WpfButton uIHideButton = this.UIVersionOneWorkitemsSWindow.UIMicrosoftVisualStudiTitleBar.UIHideButton;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(30, 31));

            // Click 'Visual Studio 2013' menu item
            Mouse.Click(uIVisualStudio2013MenuItem, new Point(101, 17));

            // Click 'View' -> 'Other Windows' -> 'VersionOne Tasks' menu item
            Mouse.Click(uIVersionOneTasksMenuItem, new Point(75, 2));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(13, 27));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(91, 27));

            // Click 'Add Task' button
            Mouse.Click(uIAddTaskButton, new Point(15, 10));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(106, 109));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(106, 109));

            // Type 'TaskName1' in text box
            uIItemEdit.Text = this.addTaskNameParams.UIItemEditText;

            // Type '{Enter}' in text box
            Keyboard.SendKeys(uIItemEdit, this.addTaskNameParams.UIItemEditSendKeys, ModifierKeys.None);

            // Click 'Save' button
            Mouse.Click(uISaveButton, new Point(13, 10));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(3, 27));

            // Click 'treeViewAdv1' client
            Mouse.Click(uITreeViewAdv1Client, new Point(8, 28));

            // Click 'Hide' button
            Mouse.Click(uIHideButton, new Point(7, 10));
        }
        
        #region Properties
        public virtual addTaskCUIParams addTaskCUIParams
        {
            get
            {
                if ((this.maddTaskCUIParams == null))
                {
                    this.maddTaskCUIParams = new addTaskCUIParams();
                }
                return this.maddTaskCUIParams;
            }
        }
        
        public virtual addTaskNameParams addTaskNameParams
        {
            get
            {
                if ((this.maddTaskNameParams == null))
                {
                    this.maddTaskNameParams = new addTaskNameParams();
                }
                return this.maddTaskNameParams;
            }
        }
        
        public UIStartWindow UIStartWindow
        {
            get
            {
                if ((this.mUIStartWindow == null))
                {
                    this.mUIStartWindow = new UIStartWindow();
                }
                return this.mUIStartWindow;
            }
        }
        
        public UIStartmenuWindow UIStartmenuWindow
        {
            get
            {
                if ((this.mUIStartmenuWindow == null))
                {
                    this.mUIStartmenuWindow = new UIStartmenuWindow();
                }
                return this.mUIStartmenuWindow;
            }
        }
        
        public UIStartPageMicrosoftViWindow UIStartPageMicrosoftViWindow
        {
            get
            {
                if ((this.mUIStartPageMicrosoftViWindow == null))
                {
                    this.mUIStartPageMicrosoftViWindow = new UIStartPageMicrosoftViWindow();
                }
                return this.mUIStartPageMicrosoftViWindow;
            }
        }
        
        public UIMicrosoftVisualStudiWindow UIMicrosoftVisualStudiWindow
        {
            get
            {
                if ((this.mUIMicrosoftVisualStudiWindow == null))
                {
                    this.mUIMicrosoftVisualStudiWindow = new UIMicrosoftVisualStudiWindow();
                }
                return this.mUIMicrosoftVisualStudiWindow;
            }
        }
        
        public UIValidationfailedWindow UIValidationfailedWindow
        {
            get
            {
                if ((this.mUIValidationfailedWindow == null))
                {
                    this.mUIValidationfailedWindow = new UIValidationfailedWindow();
                }
                return this.mUIValidationfailedWindow;
            }
        }
        
        public UIVersionOneWorkitemsSWindow UIVersionOneWorkitemsSWindow
        {
            get
            {
                if ((this.mUIVersionOneWorkitemsSWindow == null))
                {
                    this.mUIVersionOneWorkitemsSWindow = new UIVersionOneWorkitemsSWindow();
                }
                return this.mUIVersionOneWorkitemsSWindow;
            }
        }
        #endregion
        
        #region Fields
        private addTaskCUIParams maddTaskCUIParams;
        
        private addTaskNameParams maddTaskNameParams;
        
        private UIStartWindow mUIStartWindow;
        
        private UIStartmenuWindow mUIStartmenuWindow;
        
        private UIStartPageMicrosoftViWindow mUIStartPageMicrosoftViWindow;
        
        private UIMicrosoftVisualStudiWindow mUIMicrosoftVisualStudiWindow;
        
        private UIValidationfailedWindow mUIValidationfailedWindow;
        
        private UIVersionOneWorkitemsSWindow mUIVersionOneWorkitemsSWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'addTaskCUI'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class addTaskCUIParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'new task 2' in text box
        /// </summary>
        public string UIItemEditText = "new task 2";
        
        /// <summary>
        /// Type '{Enter}' in text box
        /// </summary>
        public string UIItemEditSendKeys = "{Enter}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'addTaskName'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class addTaskNameParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'TaskName1' in text box
        /// </summary>
        public string UIItemEditText = "TaskName1";
        
        /// <summary>
        /// Type '{Enter}' in text box
        /// </summary>
        public string UIItemEditSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIStartWindow : WinWindow
    {
        
        public UIStartWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Start";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("Start");
            #endregion
        }
        
        #region Properties
        public WinButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WinButton.PropertyNames.Name] = "Start";
                    this.mUIStartButton.WindowTitles.Add("Start");
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIStartButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIStartmenuWindow : WinWindow
    {
        
        public UIStartmenuWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Start menu";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DV2ControlHost";
            this.WindowTitles.Add("Start menu");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public WinClient UIStartmenuClient
        {
            get
            {
                if ((this.mUIStartmenuClient == null))
                {
                    this.mUIStartmenuClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIStartmenuClient.SearchProperties[WinControl.PropertyNames.Name] = "Start menu";
                    this.mUIStartmenuClient.WindowTitles.Add("Start menu");
                    #endregion
                }
                return this.mUIStartmenuClient;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private WinClient mUIStartmenuClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Start menu");
            #endregion
        }
        
        #region Properties
        public UIStartmenuClient UIStartmenuClient
        {
            get
            {
                if ((this.mUIStartmenuClient == null))
                {
                    this.mUIStartmenuClient = new UIStartmenuClient(this);
                }
                return this.mUIStartmenuClient;
            }
        }
        #endregion
        
        #region Fields
        private UIStartmenuClient mUIStartmenuClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIStartmenuClient : WinClient
    {
        
        public UIStartmenuClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Start menu");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIVisualStudio2013MenuItem
        {
            get
            {
                if ((this.mUIVisualStudio2013MenuItem == null))
                {
                    this.mUIVisualStudio2013MenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIVisualStudio2013MenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Visual Studio 2013";
                    this.mUIVisualStudio2013MenuItem.WindowTitles.Add("Start menu");
                    #endregion
                }
                return this.mUIVisualStudio2013MenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIVisualStudio2013MenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIStartPageMicrosoftViWindow : WpfWindow
    {
        
        public UIStartPageMicrosoftViWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Start Page - Microsoft Visual Studio";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIMenuBarMenuBar UIMenuBarMenuBar
        {
            get
            {
                if ((this.mUIMenuBarMenuBar == null))
                {
                    this.mUIMenuBarMenuBar = new UIMenuBarMenuBar(this);
                }
                return this.mUIMenuBarMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuBarMenuBar mUIMenuBarMenuBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMenuBarMenuBar : WpfControl
    {
        
        public UIMenuBarMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ControlType] = "MenuBar";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "MenuBar";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIViewMenuItem UIViewMenuItem
        {
            get
            {
                if ((this.mUIViewMenuItem == null))
                {
                    this.mUIViewMenuItem = new UIViewMenuItem(this);
                }
                return this.mUIViewMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIViewMenuItem mUIViewMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIViewMenuItem : WpfMenuItem
    {
        
        public UIViewMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfMenuItem.PropertyNames.Name] = "View";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIOtherWindowsMenuItem UIOtherWindowsMenuItem
        {
            get
            {
                if ((this.mUIOtherWindowsMenuItem == null))
                {
                    this.mUIOtherWindowsMenuItem = new UIOtherWindowsMenuItem(this);
                }
                return this.mUIOtherWindowsMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIOtherWindowsMenuItem mUIOtherWindowsMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIOtherWindowsMenuItem : WpfMenuItem
    {
        
        public UIOtherWindowsMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfMenuItem.PropertyNames.Name] = "Other Windows";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfMenuItem UIVersionOneTasksMenuItem
        {
            get
            {
                if ((this.mUIVersionOneTasksMenuItem == null))
                {
                    this.mUIVersionOneTasksMenuItem = new WpfMenuItem(this);
                    #region Search Criteria
                    this.mUIVersionOneTasksMenuItem.SearchProperties[WpfMenuItem.PropertyNames.Name] = "VersionOne Tasks";
                    this.mUIVersionOneTasksMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIVersionOneTasksMenuItem.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIVersionOneTasksMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfMenuItem mUIVersionOneTasksMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMicrosoftVisualStudiWindow : WinWindow
    {
        
        public UIMicrosoftVisualStudiWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Microsoft Visual Studio";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIVersionOneWorkitemsSPane UIVersionOneWorkitemsSPane
        {
            get
            {
                if ((this.mUIVersionOneWorkitemsSPane == null))
                {
                    this.mUIVersionOneWorkitemsSPane = new UIVersionOneWorkitemsSPane(this);
                }
                return this.mUIVersionOneWorkitemsSPane;
            }
        }
        #endregion
        
        #region Fields
        private UIVersionOneWorkitemsSPane mUIVersionOneWorkitemsSPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVersionOneWorkitemsSPane : WpfPane
    {
        
        public UIVersionOneWorkitemsSPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfPane.PropertyNames.ClassName] = "Uia.ViewPresenter";
            this.SearchProperties[WpfPane.PropertyNames.AutomationId] = "ST:0:0:{6b9496c7-4fbe-4807-bd6b-ccfe96d183c3}";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIVersionOneWorkitemsSPane1 UIVersionOneWorkitemsSPane1
        {
            get
            {
                if ((this.mUIVersionOneWorkitemsSPane1 == null))
                {
                    this.mUIVersionOneWorkitemsSPane1 = new UIVersionOneWorkitemsSPane1(this);
                }
                return this.mUIVersionOneWorkitemsSPane1;
            }
        }
        #endregion
        
        #region Fields
        private UIVersionOneWorkitemsSPane1 mUIVersionOneWorkitemsSPane1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVersionOneWorkitemsSPane1 : WpfControl
    {
        
        public UIVersionOneWorkitemsSPane1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ControlType] = "Pane";
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "GenericPane";
            this.SearchProperties[WpfControl.PropertyNames.Name] = "VersionOne Workitems - System (All Projects)";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UITreeViewAdv1Window UITreeViewAdv1Window
        {
            get
            {
                if ((this.mUITreeViewAdv1Window == null))
                {
                    this.mUITreeViewAdv1Window = new UITreeViewAdv1Window(this);
                }
                return this.mUITreeViewAdv1Window;
            }
        }
        
        public UITsMenuToolBar UITsMenuToolBar
        {
            get
            {
                if ((this.mUITsMenuToolBar == null))
                {
                    this.mUITsMenuToolBar = new UITsMenuToolBar(this);
                }
                return this.mUITsMenuToolBar;
            }
        }
        
        public UIItemWindow1 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow1(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITreeViewAdv1Window mUITreeViewAdv1Window;
        
        private UITsMenuToolBar mUITsMenuToolBar;
        
        private UIItemWindow1 mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UITreeViewAdv1Window : WinWindow
    {
        
        public UITreeViewAdv1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "tvWorkitems";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WinClient UITreeViewAdv1Client
        {
            get
            {
                if ((this.mUITreeViewAdv1Client == null))
                {
                    this.mUITreeViewAdv1Client = new WinClient(this);
                    #region Search Criteria
                    this.mUITreeViewAdv1Client.SearchProperties[WinControl.PropertyNames.Name] = "treeViewAdv1";
                    this.mUITreeViewAdv1Client.WindowTitles.Add("Microsoft Visual Studio");
                    #endregion
                }
                return this.mUITreeViewAdv1Client;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUITreeViewAdv1Client;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UITsMenuToolBar : WinToolBar
    {
        
        public UITsMenuToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinToolBar.PropertyNames.Name] = "tsMenu";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddTaskButton
        {
            get
            {
                if ((this.mUIAddTaskButton == null))
                {
                    this.mUIAddTaskButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddTaskButton.SearchProperties[WinButton.PropertyNames.Name] = "Add Task";
                    this.mUIAddTaskButton.WindowTitles.Add("Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIAddTaskButton;
            }
        }
        
        public WinButton UISaveButton
        {
            get
            {
                if ((this.mUISaveButton == null))
                {
                    this.mUISaveButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISaveButton.SearchProperties[WinButton.PropertyNames.Name] = "Save";
                    this.mUISaveButton.WindowTitles.Add("Microsoft Visual Studio");
                    #endregion
                }
                return this.mUISaveButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddTaskButton;
        
        private WinButton mUISaveButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIValidationfailedWindow : WinWindow
    {
        
        public UIValidationfailedWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Validation failed";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Validation failed");
            #endregion
        }
        
        #region Properties
        public UICloseWindow UICloseWindow
        {
            get
            {
                if ((this.mUICloseWindow == null))
                {
                    this.mUICloseWindow = new UICloseWindow(this);
                }
                return this.mUICloseWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICloseWindow mUICloseWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UICloseWindow : WinWindow
    {
        
        public UICloseWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnOK";
            this.WindowTitles.Add("Validation failed");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Validation failed");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVersionOneWorkitemsSWindow : WpfWindow
    {
        
        public UIVersionOneWorkitemsSWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "VersionOne Workitems - System (All Projects)";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UIMicrosoftVisualStudiTitleBar UIMicrosoftVisualStudiTitleBar
        {
            get
            {
                if ((this.mUIMicrosoftVisualStudiTitleBar == null))
                {
                    this.mUIMicrosoftVisualStudiTitleBar = new UIMicrosoftVisualStudiTitleBar(this);
                }
                return this.mUIMicrosoftVisualStudiTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIMicrosoftVisualStudiTitleBar mUIMicrosoftVisualStudiTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMicrosoftVisualStudiTitleBar : WpfTitleBar
    {
        
        public UIMicrosoftVisualStudiTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTitleBar.PropertyNames.AutomationId] = "DragHeader";
            this.WindowTitles.Add("Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfButton UIHideButton
        {
            get
            {
                if ((this.mUIHideButton == null))
                {
                    this.mUIHideButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIHideButton.SearchProperties[WpfButton.PropertyNames.Name] = "Hide";
                    this.mUIHideButton.WindowTitles.Add("Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIHideButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIHideButton;
        #endregion
    }
}