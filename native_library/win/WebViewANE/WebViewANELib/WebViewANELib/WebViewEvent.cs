#region License
// Copyright 2017 Tua Rua Ltd.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 
//  Additional Terms
//  No part, or derivative of this Air Native Extensions's code is permitted 
//  to be sold as the basis of a commercially packaged Air Native Extension which 
//  undertakes the same purpose as this software. That is, a WebView for Windows, 
//  OSX and/or iOS and/or Android.
//  All Rights Reserved. Tua Rua Ltd.
#endregion

namespace WebViewANELib {
    public struct WebViewEvent {
        public const string AsCallbackEvent = "TRWV.as.CALLBACK";
        public const string JsCallbackEvent = "TRWV.js.CALLBACK";
        public const string OnDownloadProgress = "WebView.OnDownloadProgress";
        public const string OnDownloadComplete = "WebView.OnDownloadComplete";
        public const string OnDownloadCancel = "WebView.OnDownloadCancel";
        public const string OnPropertyChange = "WebView.OnPropertyChange";
        public const string OnEscKey = "WebView.OnEscKey";
        public const string OnFail = "WebView.OnFail";
        public const string OnUrlBlocked = "WebView.OnUrlBlocked";
        public const string OnPopupBlocked = "WebView.OnPopupBlocked";
        public const string OnPdfPrinted = "WebView.OnPdfPrinted";
    }
}