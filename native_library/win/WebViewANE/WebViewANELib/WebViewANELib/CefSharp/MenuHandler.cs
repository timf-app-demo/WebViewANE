// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp;

namespace WebViewANELib.CefSharp {
    internal class MenuHandler : IContextMenuHandler {
        //private const int ShowDevTools = 26501;
        //private const int CloseDevTools = 26502;

        void IContextMenuHandler.OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame,
            IContextMenuParams parameters, IMenuModel model) {
            //To disable the menu then call clear
            model.Clear();

            /* //Removing existing menu item
             //bool removed = model.Remove(CefMenuCommand.ViewSource); // Remove "View Source" option
 
             //Add new custom menu items
             model.AddItem((CefMenuCommand) ShowDevTools, "Show DevTools");
             model.AddItem((CefMenuCommand) CloseDevTools, "Close DevTools");*/

            //model.AddItem(CefMenuCommand.Back, "Back");
        }

        bool IContextMenuHandler.OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame,
            IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags) {
            return false;
        }

        void IContextMenuHandler.OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame) { }

        bool IContextMenuHandler.RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame,
            IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback) {
            return false;
        }
    }
}