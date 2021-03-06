//------------------------------------------------------------------------------
// <copyright file="IXPathEnvironment.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
// <owner current="true" primary="true">[....]</owner>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Xml.Xsl.Qil;

namespace System.Xml.Xsl.XPath {

    // <spec>http://www.w3.org/TR/xslt20/#dt-focus</spec>
    internal interface IFocus {
        // The context item:     the item currently being processed
        QilNode GetCurrent();

        // The context position: the position of the context item within the sequence of items
        // currently being processed
        QilNode GetPosition();

        // The context size:     the number of items in the sequence of items currently being processed
        QilNode GetLast();
    }

    internal interface IXPathEnvironment : IFocus {
        XPathQilFactory Factory { get; }

        // Resolution of variables, functions, and prefixes
        QilNode ResolveVariable(string prefix, string name);
        QilNode ResolveFunction(string prefix, string name, IList<QilNode> args, IFocus env);
        string  ResolvePrefix  (string prefix);
    }
}
