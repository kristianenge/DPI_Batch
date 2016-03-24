namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write8_WorkflowDefinition(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"WorkflowDefinition", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write3_WorkflowDefinition(@"WorkflowDefinition", namespace1, ((global::MyToolkit.WorkflowEngine.WorkflowDefinition)o), true, false, namespace1, @"");
        }

        public void Write9_ArrayOfActivityData(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ArrayOfActivityData", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData> a = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)((global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)o);
                if ((object)(a) == null) {
                    WriteNullTagLiteral(@"ArrayOfActivityData", defaultNamespace);
                }
                else {
                    WriteStartElement(@"ArrayOfActivityData", namespace2, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write5_ActivityData(@"ActivityData", namespace3, ((global::MyToolkit.WorkflowEngine.ActivityData)a[ia]), true, false, namespace3, @"");
                    }
                    WriteEndElement();
                }
            }
        }

        public void Write10_Item(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ArrayOfKeyValuePairOfStringObject", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>> a = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)((global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)o);
                if ((object)(a) == null) {
                    WriteNullTagLiteral(@"ArrayOfKeyValuePairOfStringObject", defaultNamespace);
                }
                else {
                    WriteStartElement(@"ArrayOfKeyValuePairOfStringObject", namespace4, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write6_KeyValuePairOfStringObject(@"KeyValuePairOfStringObject", namespace5, ((global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>)a[ia]), true, false, namespace5, @"");
                    }
                    WriteEndElement();
                }
            }
        }

        public void Write11_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace6, ((global::System.Object)o), true, false, namespace6, @"");
        }

        public void Write12_ArrayOfAnyType1(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ArrayOfAnyType1", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.Object> a = (global::System.Collections.Generic.List<global::System.Object>)((global::System.Collections.Generic.List<global::System.Object>)o);
                if ((object)(a) == null) {
                    WriteNullTagLiteral(@"ArrayOfAnyType1", defaultNamespace);
                }
                else {
                    WriteStartElement(@"ArrayOfAnyType1", namespace7, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write1_Object(@"anyType", namespace8, ((global::System.Object)a[ia]), true, false, namespace8, @"");
                    }
                    WriteEndElement();
                }
            }
        }

        public void Write13_Item(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ArrayOfKeyValuePairOfObjectObject", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>> a = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)((global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)o);
                if ((object)(a) == null) {
                    WriteNullTagLiteral(@"ArrayOfKeyValuePairOfObjectObject", defaultNamespace);
                }
                else {
                    WriteStartElement(@"ArrayOfKeyValuePairOfObjectObject", namespace9, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write7_KeyValuePairOfObjectObject(@"KeyValuePairOfObjectObject", namespace10, ((global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>)a[ia]), true, false, namespace10, @"");
                    }
                    WriteEndElement();
                }
            }
        }

        public void Write14_anyType(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"anyType", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"anyType", namespace11, ((global::System.Object)o), true, false, namespace11, @"");
        }

        void Write1_Object(string n, string ns, global::System.Object o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::System.Object)) {
                }
                else if (t == typeof(global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>)) {
                    Write7_KeyValuePairOfObjectObject(n, ns,(global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>)) {
                    Write6_KeyValuePairOfStringObject(n, ns,(global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::MyToolkit.WorkflowEngine.ActivityData)) {
                    Write5_ActivityData(n, ns,(global::MyToolkit.WorkflowEngine.ActivityData)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::MyToolkit.WorkflowEngine.WorkflowActivityOutput)) {
                    Write4_WorkflowActivityOutput(n, ns,(global::MyToolkit.WorkflowEngine.WorkflowActivityOutput)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::MyToolkit.WorkflowEngine.WorkflowDefinition)) {
                    Write3_WorkflowDefinition(n, ns,(global::MyToolkit.WorkflowEngine.WorkflowDefinition)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::MyToolkit.WorkflowEngine.WorkflowTransition)) {
                    Write2_WorkflowTransition(n, ns,(global::MyToolkit.WorkflowEngine.WorkflowTransition)o, isNullable, true);
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::System.Object>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfAnyType", @"");
                    {
                        global::System.Collections.Generic.List<global::System.Object> a = (global::System.Collections.Generic.List<global::System.Object>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write1_Object(@"Activity", namespace12, ((global::System.Object)a[ia]), true, false, namespace12, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfWorkflowTransition", @"");
                    {
                        global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition> a = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace13 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write2_WorkflowTransition(@"Transition", namespace13, ((global::MyToolkit.WorkflowEngine.WorkflowTransition)a[ia]), true, false, namespace13, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfActivityData", @"");
                    {
                        global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData> a = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace14 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write5_ActivityData(@"ActivityData", namespace14, ((global::MyToolkit.WorkflowEngine.ActivityData)a[ia]), true, false, namespace14, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfKeyValuePairOfStringObject", @"");
                    {
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>> a = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace15 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write6_KeyValuePairOfStringObject(@"KeyValuePairOfStringObject", namespace15, ((global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>)a[ia]), true, false, namespace15, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::System.Object>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfAnyType1", @"");
                    {
                        global::System.Collections.Generic.List<global::System.Object> a = (global::System.Collections.Generic.List<global::System.Object>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace16 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write1_Object(@"anyType", namespace16, ((global::System.Object)a[ia]), true, false, namespace16, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else if (t == typeof(global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)) {
                    Writer.WriteStartElement(n, ns);
                    WriteXsiType(@"ArrayOfKeyValuePairOfObjectObject", @"");
                    {
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>> a = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)o;
                        if (a != null) {
                            for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                                string namespace17 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                                Write7_KeyValuePairOfObjectObject(@"KeyValuePairOfObjectObject", namespace17, ((global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>)a[ia]), true, false, namespace17, @"");
                            }
                        }
                    }
                    Writer.WriteEndElement();
                    return;
                }
                else {
                    WriteTypedPrimitive(n, ns, o, true);
                    return;
                }
            }
            WriteStartElement(n, ns, o, false, null);
            WriteEndElement(o);
        }

        void Write7_KeyValuePairOfObjectObject(string n, string ns, global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object> o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"KeyValuePairOfObjectObject", defaultNamespace);
            string namespace18 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"Key", namespace18, ((global::System.Object)o.@Key), false, false, namespace18, @"");
            string namespace19 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"Value", namespace19, ((global::System.Object)o.@Value), false, false, namespace19, @"");
            WriteEndElement(o);
        }

        void Write6_KeyValuePairOfStringObject(string n, string ns, global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object> o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"KeyValuePairOfStringObject", defaultNamespace);
            string namespace20 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Key", namespace20, ((global::System.String)o.@Key));
            string namespace21 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write1_Object(@"Value", namespace21, ((global::System.Object)o.@Value), false, false, namespace21, @"");
            WriteEndElement(o);
        }

        void Write5_ActivityData(string n, string ns, global::MyToolkit.WorkflowEngine.ActivityData o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MyToolkit.WorkflowEngine.ActivityData)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ActivityData", defaultNamespace);
            string namespace22 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"ActivityId", namespace22, ((global::System.String)o.@ActivityId));
            string namespace23 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write4_WorkflowActivityOutput(@"Output", namespace23, ((global::MyToolkit.WorkflowEngine.WorkflowActivityOutput)o.@Output), false, false, namespace23, @"");
            WriteEndElement(o);
        }

        void Write4_WorkflowActivityOutput(string n, string ns, global::MyToolkit.WorkflowEngine.WorkflowActivityOutput o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MyToolkit.WorkflowEngine.WorkflowActivityOutput)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"WorkflowActivityOutput", defaultNamespace);
            WriteEndElement(o);
        }

        void Write2_WorkflowTransition(string n, string ns, global::MyToolkit.WorkflowEngine.WorkflowTransition o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MyToolkit.WorkflowEngine.WorkflowTransition)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"WorkflowTransition", defaultNamespace);
            WriteAttribute(@"From", @"", ((global::System.String)o.@From));
            WriteAttribute(@"To", @"", ((global::System.String)o.@To));
            WriteAttribute(@"Condition", @"", ((global::System.String)o.@Condition));
            WriteEndElement(o);
        }

        void Write3_WorkflowDefinition(string n, string ns, global::MyToolkit.WorkflowEngine.WorkflowDefinition o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MyToolkit.WorkflowEngine.WorkflowDefinition)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"WorkflowDefinition", defaultNamespace);
            string namespace24 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"StartActivity", namespace24, ((global::System.String)o.@StartActivityId));
            string namespace25 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::System.Object> a = (global::System.Collections.Generic.List<global::System.Object>)((global::System.Collections.Generic.List<global::System.Object>)o.@RawActivities);
                if (a != null){
                    WriteStartElement(@"Activities", namespace25, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace26 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write1_Object(@"Activity", namespace26, ((global::System.Object)a[ia]), true, false, namespace26, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace27 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition> a = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)((global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)o.@Transitions);
                if (a != null){
                    WriteStartElement(@"Transitions", namespace27, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace28 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write2_WorkflowTransition(@"Transition", namespace28, ((global::MyToolkit.WorkflowEngine.WorkflowTransition)a[ia]), true, false, namespace28, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read8_WorkflowDefinition(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_WorkflowDefinition && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read3_WorkflowDefinition(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":WorkflowDefinition");
            }
            return (object)o;
        }

        public object Read9_ArrayOfActivityData(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_ArrayOfActivityData && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    if (!ReadNull()) {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>();
                        global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData> a_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)o;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations0 = 0;
                            int readerCount0 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id4_ActivityData && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read5_ActivityData(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":ActivityData");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":ActivityData");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations0, ref readerCount0);
                            }
                        ReadEndElement();
                        }
                    }
                    else {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>();
                        global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData> a_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)o;
                    }
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ArrayOfActivityData");
            }
            return (object)o;
        }

        public object Read10_Item(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    if (!ReadNull()) {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>();
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>> a_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)o;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations1 = 0;
                            int readerCount1 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id6_KeyValuePairOfStringObject && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read6_KeyValuePairOfStringObject(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":KeyValuePairOfStringObject");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":KeyValuePairOfStringObject");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations1, ref readerCount1);
                            }
                        ReadEndElement();
                        }
                    }
                    else {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>();
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>> a_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)o;
                    }
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ArrayOfKeyValuePairOfStringObject");
            }
            return (object)o;
        }

        public object Read11_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id7_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        public object Read12_ArrayOfAnyType1(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_ArrayOfAnyType1 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    if (!ReadNull()) {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::System.Object>();
                        global::System.Collections.Generic.List<global::System.Object> a_0_0 = (global::System.Collections.Generic.List<global::System.Object>)o;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations2 = 0;
                            int readerCount2 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id7_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read1_Object(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":anyType");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":anyType");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations2, ref readerCount2);
                            }
                        ReadEndElement();
                        }
                    }
                    else {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::System.Object>();
                        global::System.Collections.Generic.List<global::System.Object> a_0_0 = (global::System.Collections.Generic.List<global::System.Object>)o;
                    }
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ArrayOfAnyType1");
            }
            return (object)o;
        }

        public object Read13_Item(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id9_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    if (!ReadNull()) {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>();
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>> a_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)o;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations3 = 0;
                            int readerCount3 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id10_KeyValuePairOfObjectObject && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read7_KeyValuePairOfObjectObject(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":KeyValuePairOfObjectObject");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":KeyValuePairOfObjectObject");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations3, ref readerCount3);
                            }
                        ReadEndElement();
                        }
                    }
                    else {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>();
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>> a_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)o;
                    }
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ArrayOfKeyValuePairOfObjectObject");
            }
            return (object)o;
        }

        public object Read14_anyType(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id7_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read1_Object(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":anyType");
            }
            return (object)o;
        }

        global::System.Object Read1_Object(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
                if (isNull) {
                    if (xsiType != null) return (global::System.Object)ReadTypedNull(xsiType);
                    else return null;
                }
                if (xsiType == null) {
                    return ReadTypedPrimitive(new System.Xml.XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema"));
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_KeyValuePairOfObjectObject && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read7_KeyValuePairOfObjectObject(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_KeyValuePairOfStringObject && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read6_KeyValuePairOfStringObject(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_ActivityData && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read5_ActivityData(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_WorkflowActivityOutput && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read4_WorkflowActivityOutput(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_WorkflowDefinition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read3_WorkflowDefinition(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_WorkflowTransition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item)))
                    return Read2_WorkflowTransition(isNullable, false, defaultNamespace);
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_ArrayOfAnyType && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::System.Object> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::System.Object>();
                        global::System.Collections.Generic.List<global::System.Object> z_0_0 = (global::System.Collections.Generic.List<global::System.Object>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations4 = 0;
                            int readerCount4 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id14_Activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read1_Object(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Activity");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Activity");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations4, ref readerCount4);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_ArrayOfWorkflowTransition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>();
                        global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition> z_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations5 = 0;
                            int readerCount5 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id16_Transition && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read2_WorkflowTransition(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Transition");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Transition");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations5, ref readerCount5);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_ArrayOfActivityData && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>();
                        global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData> z_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations6 = 0;
                            int readerCount6 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id4_ActivityData && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read5_ActivityData(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":ActivityData");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":ActivityData");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations6, ref readerCount6);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id5_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>();
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>> z_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations7 = 0;
                            int readerCount7 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id6_KeyValuePairOfStringObject && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read6_KeyValuePairOfStringObject(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":KeyValuePairOfStringObject");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":KeyValuePairOfStringObject");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations7, ref readerCount7);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_ArrayOfAnyType1 && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::System.Object> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::System.Object>();
                        global::System.Collections.Generic.List<global::System.Object> z_0_0 = (global::System.Collections.Generic.List<global::System.Object>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations8 = 0;
                            int readerCount8 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id7_anyType && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read1_Object(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":anyType");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":anyType");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations8, ref readerCount8);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_Item && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                    global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>> a = null;
                    if (!ReadNull()) {
                        if ((object)(a) == null) a = new global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>();
                        global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>> z_0_0 = (global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)a;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations9 = 0;
                            int readerCount9 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id10_KeyValuePairOfObjectObject && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(z_0_0) == null) Reader.Skip(); else z_0_0.Add(Read7_KeyValuePairOfObjectObject(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":KeyValuePairOfObjectObject");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":KeyValuePairOfObjectObject");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations9, ref readerCount9);
                            }
                        ReadEndElement();
                        }
                    }
                    return a;
                }
                else
                    return ReadTypedPrimitive((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::System.Object o;
                o = new global::System.Object();
                bool[] paramsRead = new bool[0];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations10 = 0;
                int readerCount10 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations10, ref readerCount10);
                }
                ReadEndElement();
                return o;
            }

            global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object> Read7_KeyValuePairOfObjectObject(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_KeyValuePairOfObjectObject && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object> o;
                o = new global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations11 = 0;
                int readerCount11 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id17_Key && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Key = Read1_Object(false, true, defaultNamespace);
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id18_Value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Value = Read1_Object(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Key, :Value");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Key, :Value");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations11, ref readerCount11);
                }
                ReadEndElement();
                return o;
            }

            global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object> Read6_KeyValuePairOfStringObject(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_KeyValuePairOfStringObject && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object> o;
                o = new global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations12 = 0;
                int readerCount12 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id17_Key && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@Key = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id18_Value && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Value = Read1_Object(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":Key, :Value");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Key, :Value");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations12, ref readerCount12);
                }
                ReadEndElement();
                return o;
            }

            global::MyToolkit.WorkflowEngine.ActivityData Read5_ActivityData(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_ActivityData && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::MyToolkit.WorkflowEngine.ActivityData o;
                o = new global::MyToolkit.WorkflowEngine.ActivityData();
                bool[] paramsRead = new bool[2];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations13 = 0;
                int readerCount13 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id19_ActivityId && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@ActivityId = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id20_Output && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            o.@Output = Read4_WorkflowActivityOutput(false, true, defaultNamespace);
                            paramsRead[1] = true;
                        }
                        else {
                            UnknownNode((object)o, @":ActivityId, :Output");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":ActivityId, :Output");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations13, ref readerCount13);
                }
                ReadEndElement();
                return o;
            }

            global::MyToolkit.WorkflowEngine.WorkflowActivityOutput Read4_WorkflowActivityOutput(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_WorkflowActivityOutput && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::MyToolkit.WorkflowEngine.WorkflowActivityOutput o;
                o = new global::MyToolkit.WorkflowEngine.WorkflowActivityOutput();
                bool[] paramsRead = new bool[0];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations14 = 0;
                int readerCount14 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations14, ref readerCount14);
                }
                ReadEndElement();
                return o;
            }

            global::MyToolkit.WorkflowEngine.WorkflowTransition Read2_WorkflowTransition(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_WorkflowTransition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::MyToolkit.WorkflowEngine.WorkflowTransition o;
                o = new global::MyToolkit.WorkflowEngine.WorkflowTransition();
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id21_From && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@From = Reader.Value;
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id22_To && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@To = Reader.Value;
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id23_Condition && string.Equals(Reader.NamespaceURI, id2_Item))) {
                        o.@Condition = Reader.Value;
                        paramsRead[2] = true;
                    }
                    else if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o, @":From, :To, :Condition");
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations15 = 0;
                int readerCount15 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        UnknownNode((object)o, @"");
                    }
                    else {
                        UnknownNode((object)o, @"");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations15, ref readerCount15);
                }
                ReadEndElement();
                return o;
            }

            global::MyToolkit.WorkflowEngine.WorkflowDefinition Read3_WorkflowDefinition(bool isNullable, bool checkType, string defaultNamespace = null) {
                System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
                bool isNull = false;
                if (isNullable) isNull = ReadNull();
                if (checkType) {
                if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_WorkflowDefinition && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
                }
                else
                    throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
                }
                if (isNull) return null;
                global::MyToolkit.WorkflowEngine.WorkflowDefinition o;
                o = new global::MyToolkit.WorkflowEngine.WorkflowDefinition();
                if ((object)(o.@RawActivities) == null) o.@RawActivities = new global::System.Collections.Generic.List<global::System.Object>();
                global::System.Collections.Generic.List<global::System.Object> a_1 = (global::System.Collections.Generic.List<global::System.Object>)o.@RawActivities;
                if ((object)(o.@Transitions) == null) o.@Transitions = new global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>();
                global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition> a_2 = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)o.@Transitions;
                bool[] paramsRead = new bool[3];
                while (Reader.MoveToNextAttribute()) {
                    if (!IsXmlnsAttribute(Reader.Name)) {
                        UnknownNode((object)o);
                    }
                }
                Reader.MoveToElement();
                if (Reader.IsEmptyElement) {
                    Reader.Skip();
                    return o;
                }
                Reader.ReadStartElement();
                Reader.MoveToContent();
                int whileIterations16 = 0;
                int readerCount16 = ReaderCount;
                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id24_StartActivity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            {
                                o.@StartActivityId = Reader.ReadElementContentAsString();
                            }
                            paramsRead[0] = true;
                        }
                        else if (((object) Reader.LocalName == (object)id25_Activities && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@RawActivities) == null) o.@RawActivities = new global::System.Collections.Generic.List<global::System.Object>();
                                global::System.Collections.Generic.List<global::System.Object> a_1_0 = (global::System.Collections.Generic.List<global::System.Object>)o.@RawActivities;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations17 = 0;
                                    int readerCount17 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id14_Activity && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read1_Object(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Activity");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Activity");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations17, ref readerCount17);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else if (((object) Reader.LocalName == (object)id26_Transitions && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                            if (!ReadNull()) {
                                if ((object)(o.@Transitions) == null) o.@Transitions = new global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>();
                                global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition> a_2_0 = (global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.WorkflowTransition>)o.@Transitions;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations18 = 0;
                                    int readerCount18 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id16_Transition && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                                if ((object)(a_2_0) == null) Reader.Skip(); else a_2_0.Add(Read2_WorkflowTransition(true, true, defaultNamespace));
                                            }
                                            else {
                                                UnknownNode(null, @":Transition");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @":Transition");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations18, ref readerCount18);
                                    }
                                ReadEndElement();
                                }
                            }
                        }
                        else {
                            UnknownNode((object)o, @":StartActivity, :Activities, :Transitions");
                        }
                    }
                    else {
                        UnknownNode((object)o, @":StartActivity, :Activities, :Transitions");
                    }
                    Reader.MoveToContent();
                    CheckReaderCount(ref whileIterations16, ref readerCount16);
                }
                ReadEndElement();
                return o;
            }

            protected override void InitCallbacks() {
            }

            string id7_anyType;
            string id25_Activities;
            string id3_ArrayOfActivityData;
            string id5_Item;
            string id13_ArrayOfAnyType;
            string id8_ArrayOfAnyType1;
            string id24_StartActivity;
            string id10_KeyValuePairOfObjectObject;
            string id20_Output;
            string id14_Activity;
            string id18_Value;
            string id4_ActivityData;
            string id22_To;
            string id26_Transitions;
            string id1_WorkflowDefinition;
            string id19_ActivityId;
            string id11_WorkflowActivityOutput;
            string id16_Transition;
            string id9_Item;
            string id6_KeyValuePairOfStringObject;
            string id23_Condition;
            string id2_Item;
            string id12_WorkflowTransition;
            string id21_From;
            string id17_Key;
            string id15_ArrayOfWorkflowTransition;

            protected override void InitIDs() {
                id7_anyType = Reader.NameTable.Add(@"anyType");
                id25_Activities = Reader.NameTable.Add(@"Activities");
                id3_ArrayOfActivityData = Reader.NameTable.Add(@"ArrayOfActivityData");
                id5_Item = Reader.NameTable.Add(@"ArrayOfKeyValuePairOfStringObject");
                id13_ArrayOfAnyType = Reader.NameTable.Add(@"ArrayOfAnyType");
                id8_ArrayOfAnyType1 = Reader.NameTable.Add(@"ArrayOfAnyType1");
                id24_StartActivity = Reader.NameTable.Add(@"StartActivity");
                id10_KeyValuePairOfObjectObject = Reader.NameTable.Add(@"KeyValuePairOfObjectObject");
                id20_Output = Reader.NameTable.Add(@"Output");
                id14_Activity = Reader.NameTable.Add(@"Activity");
                id18_Value = Reader.NameTable.Add(@"Value");
                id4_ActivityData = Reader.NameTable.Add(@"ActivityData");
                id22_To = Reader.NameTable.Add(@"To");
                id26_Transitions = Reader.NameTable.Add(@"Transitions");
                id1_WorkflowDefinition = Reader.NameTable.Add(@"WorkflowDefinition");
                id19_ActivityId = Reader.NameTable.Add(@"ActivityId");
                id11_WorkflowActivityOutput = Reader.NameTable.Add(@"WorkflowActivityOutput");
                id16_Transition = Reader.NameTable.Add(@"Transition");
                id9_Item = Reader.NameTable.Add(@"ArrayOfKeyValuePairOfObjectObject");
                id6_KeyValuePairOfStringObject = Reader.NameTable.Add(@"KeyValuePairOfStringObject");
                id23_Condition = Reader.NameTable.Add(@"Condition");
                id2_Item = Reader.NameTable.Add(@"");
                id12_WorkflowTransition = Reader.NameTable.Add(@"WorkflowTransition");
                id21_From = Reader.NameTable.Add(@"From");
                id17_Key = Reader.NameTable.Add(@"Key");
                id15_ArrayOfWorkflowTransition = Reader.NameTable.Add(@"ArrayOfWorkflowTransition");
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
            protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
                return new XmlSerializationReader1();
            }
            protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
                return new XmlSerializationWriter1();
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class WorkflowDefinitionSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"WorkflowDefinition", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write8_WorkflowDefinition(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read8_WorkflowDefinition(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ListOfActivityDataSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ArrayOfActivityData", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write9_ArrayOfActivityData(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read9_ArrayOfActivityData(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ListOfKeyValuePairOfStringObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ArrayOfKeyValuePairOfStringObject", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write10_Item(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read10_Item(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"anyType", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write11_anyType(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read11_anyType(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ListOfObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ArrayOfAnyType1", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write12_ArrayOfAnyType1(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read12_ArrayOfAnyType1(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public sealed class ListOfKeyValuePairOfObjectObjectSerializer : XmlSerializer1 {

            public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
                return xmlReader.IsStartElement(@"ArrayOfKeyValuePairOfObjectObject", this.DefaultNamespace ?? @"");
            }

            protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
                ((XmlSerializationWriter1)writer).Write13_Item(objectToSerialize, this.DefaultNamespace, @"");
            }

            protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
                return ((XmlSerializationReader1)reader).Read13_Item(this.DefaultNamespace);
            }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
            public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
            public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
            System.Collections.IDictionary readMethods = null;
            public override System.Collections.IDictionary ReadMethods {
                get {
                    if (readMethods == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                        _tmp[@"MyToolkit.WorkflowEngine.WorkflowDefinition::"] = @"Read8_WorkflowDefinition";
                        _tmp[@"System.Collections.Generic.List`1[[MyToolkit.WorkflowEngine.ActivityData, MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::"] = @"Read9_ArrayOfActivityData";
                        _tmp[@"System.Collections.Generic.List`1[[MyToolkit.Serialization.XmlSerialization+KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::"] = @"Read10_Item";
                        _tmp[@"System.Object::"] = @"Read11_anyType";
                        _tmp[@"System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]::"] = @"Read12_ArrayOfAnyType1";
                        _tmp[@"System.Collections.Generic.List`1[[MyToolkit.Serialization.XmlSerialization+KeyValuePair`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::"] = @"Read13_Item";
                        _tmp[@"System.Object::"] = @"Read14_anyType";
                        if (readMethods == null) readMethods = _tmp;
                    }
                    return readMethods;
                }
            }
            System.Collections.IDictionary writeMethods = null;
            public override System.Collections.IDictionary WriteMethods {
                get {
                    if (writeMethods == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                        _tmp[@"MyToolkit.WorkflowEngine.WorkflowDefinition::"] = @"Write8_WorkflowDefinition";
                        _tmp[@"System.Collections.Generic.List`1[[MyToolkit.WorkflowEngine.ActivityData, MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::"] = @"Write9_ArrayOfActivityData";
                        _tmp[@"System.Collections.Generic.List`1[[MyToolkit.Serialization.XmlSerialization+KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::"] = @"Write10_Item";
                        _tmp[@"System.Object::"] = @"Write11_anyType";
                        _tmp[@"System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]::"] = @"Write12_ArrayOfAnyType1";
                        _tmp[@"System.Collections.Generic.List`1[[MyToolkit.Serialization.XmlSerialization+KeyValuePair`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::"] = @"Write13_Item";
                        _tmp[@"System.Object::"] = @"Write14_anyType";
                        if (writeMethods == null) writeMethods = _tmp;
                    }
                    return writeMethods;
                }
            }
            System.Collections.IDictionary typedSerializers = null;
            public override System.Collections.IDictionary TypedSerializers {
                get {
                    if (typedSerializers == null) {
                        System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                        _tmp.Add(@"System.Collections.Generic.List`1[[MyToolkit.Serialization.XmlSerialization+KeyValuePair`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::", new ListOfKeyValuePairOfObjectObjectSerializer());
                        _tmp.Add(@"System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]::", new ListOfObjectSerializer());
                        _tmp.Add(@"System.Collections.Generic.List`1[[MyToolkit.Serialization.XmlSerialization+KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::", new ListOfKeyValuePairOfStringObjectSerializer());
                        _tmp.Add(@"System.Object::", new ObjectSerializer());
                        _tmp.Add(@"MyToolkit.WorkflowEngine.WorkflowDefinition::", new WorkflowDefinitionSerializer());
                        _tmp.Add(@"System.Collections.Generic.List`1[[MyToolkit.WorkflowEngine.ActivityData, MyToolkit, Version=2.5.11.0, Culture=neutral, PublicKeyToken=3e349a1360994d26]]::", new ListOfActivityDataSerializer());
                        if (typedSerializers == null) typedSerializers = _tmp;
                    }
                    return typedSerializers;
                }
            }
            public override System.Boolean CanSerialize(System.Type type) {
                if (type == typeof(global::MyToolkit.WorkflowEngine.WorkflowDefinition)) return true;
                if (type == typeof(global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)) return true;
                if (type == typeof(global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)) return true;
                if (type == typeof(global::System.Object)) return true;
                if (type == typeof(global::System.Collections.Generic.List<global::System.Object>)) return true;
                if (type == typeof(global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)) return true;
                if (type == typeof(global::System.Reflection.TypeInfo)) return true;
                return false;
            }
            public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
                if (type == typeof(global::MyToolkit.WorkflowEngine.WorkflowDefinition)) return new WorkflowDefinitionSerializer();
                if (type == typeof(global::System.Collections.Generic.List<global::MyToolkit.WorkflowEngine.ActivityData>)) return new ListOfActivityDataSerializer();
                if (type == typeof(global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.String,global::System.Object>>)) return new ListOfKeyValuePairOfStringObjectSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                if (type == typeof(global::System.Collections.Generic.List<global::System.Object>)) return new ListOfObjectSerializer();
                if (type == typeof(global::System.Collections.Generic.List<global::MyToolkit.Serialization.XmlSerialization.KeyValuePair<global::System.Object,global::System.Object>>)) return new ListOfKeyValuePairOfObjectObjectSerializer();
                if (type == typeof(global::System.Object)) return new ObjectSerializer();
                return null;
            }
            public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
        }

        [System.Runtime.CompilerServices.__BlockReflection]
        public static class ActivatorHelper {
            public static object CreateInstance(System.Type type) {
                System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
                foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                    if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                        return ci.Invoke(null);
                    }
                }
                return System.Activator.CreateInstance(type);
            }
        }
    }
