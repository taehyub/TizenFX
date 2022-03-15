
/*
 * Copyright(c) 2022 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.ComponentModel;
using System.Xml;

namespace Tizen.NUI.Binding.Internals
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal interface INameScope
    {
        object FindByName(string name);
        void RegisterName(string name, object scopedElement);
        void UnregisterName(string name);
        [Obsolete]void RegisterName(string name, object scopedElement, IXmlLineInfo xmlLineInfo);
    }
}
 