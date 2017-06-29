using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 464
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                4, // array length: 4
                728, // index: 728, string: "id"
                731, // index: 731, string: "isNew"
                737, // index: 737, string: "name"
                742, // index: 742, string: "semester"
                4, // array length: 4
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                751, // index: 751, string: "currentSemester"
                767, // index: 767, string: "nextSemester"
                2, // array length: 2
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                5, // array length: 5
                780, // index: 780, string: "endDate"
                728, // index: 728, string: "id"
                788, // index: 788, string: "semesterEname"
                802, // index: 802, string: "semesterName"
                815, // index: 815, string: "startDate"
                5, // array length: 5
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                7, // array length: 7
                825, // index: 825, string: "course"
                832, // index: 832, string: "courseid"
                841, // index: 841, string: "ddl"
                845, // index: 845, string: "detail"
                852, // index: 852, string: "hasBeenFinished"
                728, // index: 728, string: "id"
                737, // index: 737, string: "name"
                7, // array length: 7
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                8, // array length: 8
                868, // index: 868, string: "Isfinished"
                825, // index: 825, string: "course"
                879, // index: 879, string: "courseId"
                845, // index: 845, string: "detail"
                728, // index: 728, string: "id"
                888, // index: 888, string: "owner"
                894, // index: 894, string: "regDate"
                902, // index: 902, string: "title"
                8, // array length: 8
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                4, // array length: 4
                908, // index: 908, string: "currentDate"
                751, // index: 751, string: "currentSemester"
                920, // index: 920, string: "currentTeachingWeek"
                767, // index: 767, string: "nextSemester"
                4, // array length: 4
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                5, // array length: 5
                940, // index: 940, string: "beginDate"
                780, // index: 780, string: "endDate"
                950, // index: 950, string: "semesterId"
                961, // index: 961, string: "teachingWeekId"
                976, // index: 976, string: "weekName"
                5, // array length: 5
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                10, // array length: 10
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                10, // array length: 10
                985, // index: 985, string: "dd"
                988, // index: 988, string: "fl"
                991, // index: 991, string: "grrlID"
                998, // index: 998, string: "jssj"
                1003, // index: 1003, string: "kssj"
                1008, // index: 1008, string: "nq"
                1011, // index: 1011, string: "nr"
                1014, // index: 1014, string: "sfSjtz"
                1021, // index: 1021, string: "skjc"
                1026, // index: 1026, string: "sm"
                10, // array length: 10
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                1029, // index: 1029, string: "message"
                1037, // index: 1037, string: "resultList"
                2, // array length: 2
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                1048, // index: 1048, string: "courseHomeworkInfo"
                1067, // index: 1067, string: "courseHomeworkRecord"
                2, // array length: 2
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                24, // array length: 24
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                24, // array length: 24
                1088, // index: 1088, string: "answerDate"
                1099, // index: 1099, string: "answerDetail"
                1112, // index: 1112, string: "answerLink"
                1123, // index: 1123, string: "answerLinkFilename"
                940, // index: 940, string: "beginDate"
                879, // index: 879, string: "courseId"
                1142, // index: 1142, string: "courseKnowledge"
                1158, // index: 1158, string: "courseSource"
                845, // index: 845, string: "detail"
                780, // index: 780, string: "endDate"
                1171, // index: 1171, string: "homewkAffix"
                1183, // index: 1183, string: "homewkAffixFilename"
                1203, // index: 1203, string: "homewkGroupNum"
                1218, // index: 1218, string: "homewkId"
                1227, // index: 1227, string: "homewkIndex"
                1239, // index: 1239, string: "jiaoed"
                1246, // index: 1246, string: "noteId"
                894, // index: 894, string: "regDate"
                961, // index: 961, string: "teachingWeekId"
                902, // index: 902, string: "title"
                1253, // index: 1253, string: "weiJiao"
                1261, // index: 1261, string: "yiJiao"
                1268, // index: 1268, string: "yiPi"
                1273, // index: 1273, string: "yiYue"
                24, // array length: 24
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                17, // array length: 17
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                17, // array length: 17
                1279, // index: 1279, string: "gradeUser"
                1289, // index: 1289, string: "groupId"
                1297, // index: 1297, string: "groupName"
                1307, // index: 1307, string: "homewkDetail"
                1218, // index: 1218, string: "homewkId"
                1320, // index: 1320, string: "ifDelay"
                1328, // index: 1328, string: "iffine"
                1335, // index: 1335, string: "mark"
                894, // index: 894, string: "regDate"
                1340, // index: 1340, string: "replyDate"
                1350, // index: 1350, string: "replyDetail"
                1362, // index: 1362, string: "resourcesMappingByHomewkAffix"
                1392, // index: 1392, string: "resourcesMappingByReplyAffix"
                1421, // index: 1421, string: "seqId"
                1427, // index: 1427, string: "status"
                1434, // index: 1434, string: "studentId"
                1444, // index: 1444, string: "teacherId"
                17, // array length: 17
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                14, // array length: 14
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                14, // array length: 14
                1454, // index: 1454, string: "browseNum"
                879, // index: 879, string: "courseId"
                1464, // index: 1464, string: "diskId"
                1471, // index: 1471, string: "downloadNum"
                1483, // index: 1483, string: "downloadUrl"
                1495, // index: 1495, string: "extension"
                1505, // index: 1505, string: "fileId"
                1512, // index: 1512, string: "fileName"
                1521, // index: 1521, string: "fileSize"
                1530, // index: 1530, string: "playUrl"
                894, // index: 894, string: "regDate"
                1538, // index: 1538, string: "resourcesId"
                1550, // index: 1550, string: "resourcesStatus"
                1566, // index: 1566, string: "userCode"
                14, // array length: 14
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                1029, // index: 1029, string: "message"
                1575, // index: 1575, string: "paginationList"
                2, // array length: 2
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                8, // array length: 8
                1590, // index: 1590, string: "currentPage"
                1602, // index: 1602, string: "currentPageStr"
                1617, // index: 1617, string: "pageMax"
                1625, // index: 1625, string: "pageSize"
                1634, // index: 1634, string: "pageStart"
                1644, // index: 1644, string: "recordCount"
                1656, // index: 1656, string: "recordCountStr"
                1671, // index: 1671, string: "recordList"
                8, // array length: 8
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                2, // array length: 2
                1682, // index: 1682, string: "courseNotice"
                1427, // index: 1427, string: "status"
                2, // array length: 2
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                10, // array length: 10
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                10, // array length: 10
                1695, // index: 1695, string: "browseTimes"
                879, // index: 879, string: "courseId"
                845, // index: 845, string: "detail"
                780, // index: 780, string: "endDate"
                728, // index: 728, string: "id"
                1707, // index: 1707, string: "msgPriority"
                888, // index: 888, string: "owner"
                894, // index: 894, string: "regDate"
                1427, // index: 1427, string: "status"
                902, // index: 902, string: "title"
                10, // array length: 10
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269, // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
                269  // index: 269, string: "http://schemas.datacontract.org/2004/07/ClassLibrary"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=61
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                "yToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Semesters, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Semester, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, Public" +
                                "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, Public" +
                                "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.SemestersRootObject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Currentteachingweek, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Timetable, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Event, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.CourseAssignmentsRootobject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist[], ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Coursehomeworkinfo, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Coursehomeworkrecord, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resourcesmappingbyhomewkaffix, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.AncRootObject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.PaginationList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.CourseNotice, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=17
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 322, // Course
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 322, // Course
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 322, // Course
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 6,
                    MemberNamesListIndex = 8,
                    MemberNamespacesListIndex = 13,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 329, // Semesters
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 329, // Semesters
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 329, // Semesters
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Semesters, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Semesters, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 18,
                    ContractNamespacesListIndex = 21,
                    MemberNamesListIndex = 23,
                    MemberNamespacesListIndex = 26,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 339, // Semester
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 339, // Semester
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 339, // Semester
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Semester, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Semester, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 29,
                    ContractNamespacesListIndex = 35,
                    MemberNamesListIndex = 37,
                    MemberNamespacesListIndex = 43,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 364, // Deadline
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 364, // Deadline
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 364, // Deadline
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 49,
                    ContractNamespacesListIndex = 57,
                    MemberNamesListIndex = 59,
                    MemberNamespacesListIndex = 67,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 389, // Announce
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 389, // Announce
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 389, // Announce
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 75,
                    ContractNamespacesListIndex = 84,
                    MemberNamesListIndex = 86,
                    MemberNamespacesListIndex = 95,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 398, // SemestersRootObject
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 398, // SemestersRootObject
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 398, // SemestersRootObject
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.SemestersRootObject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.SemestersRootObject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 104,
                    ContractNamespacesListIndex = 109,
                    MemberNamesListIndex = 111,
                    MemberNamespacesListIndex = 116,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 418, // Currentteachingweek
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 418, // Currentteachingweek
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 418, // Currentteachingweek
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Currentteachingweek, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Currentteachingweek, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 121,
                    ContractNamespacesListIndex = 127,
                    MemberNamesListIndex = 129,
                    MemberNamespacesListIndex = 135,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 451, // Event
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 451, // Event
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 451, // Event
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Event, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Event, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 141,
                    ContractNamespacesListIndex = 152,
                    MemberNamesListIndex = 154,
                    MemberNamespacesListIndex = 165,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 457, // CourseAssignmentsRootobject
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 457, // CourseAssignmentsRootobject
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 457, // CourseAssignmentsRootobject
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.CourseAssignmentsRootobject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.CourseAssignmentsRootobject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 176,
                    ContractNamespacesListIndex = 179,
                    MemberNamesListIndex = 181,
                    MemberNamespacesListIndex = 184,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 503, // Resultlist
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 503, // Resultlist
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 503, // Resultlist
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 187,
                    ContractNamespacesListIndex = 190,
                    MemberNamesListIndex = 192,
                    MemberNamespacesListIndex = 195,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 514, // Coursehomeworkinfo
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 514, // Coursehomeworkinfo
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 514, // Coursehomeworkinfo
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Coursehomeworkinfo, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Coursehomeworkinfo, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 198,
                    ContractNamespacesListIndex = 223,
                    MemberNamesListIndex = 225,
                    MemberNamespacesListIndex = 250,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 533, // Coursehomeworkrecord
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 533, // Coursehomeworkrecord
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 533, // Coursehomeworkrecord
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Coursehomeworkrecord, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Coursehomeworkrecord, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 275,
                    ContractNamespacesListIndex = 293,
                    MemberNamesListIndex = 295,
                    MemberNamespacesListIndex = 313,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 554, // Resourcesmappingbyhomewkaffix
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 554, // Resourcesmappingbyhomewkaffix
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 554, // Resourcesmappingbyhomewkaffix
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resourcesmappingbyhomewkaffix, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resourcesmappingbyhomewkaffix, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 331,
                    ContractNamespacesListIndex = 346,
                    MemberNamesListIndex = 348,
                    MemberNamespacesListIndex = 363,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 584, // AncRootObject
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 584, // AncRootObject
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 584, // AncRootObject
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.AncRootObject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.AncRootObject, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 378,
                    ContractNamespacesListIndex = 381,
                    MemberNamesListIndex = 383,
                    MemberNamespacesListIndex = 386,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 598, // PaginationList
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 598, // PaginationList
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 598, // PaginationList
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.PaginationList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.PaginationList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 389,
                    ContractNamespacesListIndex = 398,
                    MemberNamesListIndex = 400,
                    MemberNamespacesListIndex = 409,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 631, // RecordList
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 631, // RecordList
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 631, // RecordList
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 418,
                    ContractNamespacesListIndex = 421,
                    MemberNamesListIndex = 423,
                    MemberNamespacesListIndex = 426,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 642, // CourseNotice
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 642, // CourseNotice
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 642, // CourseNotice
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.CourseNotice, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.CourseNotice, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 429,
                    ContractNamespacesListIndex = 440,
                    MemberNamesListIndex = 442,
                    MemberNamespacesListIndex = 453,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=7
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ArrayOfCourse
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 255, // ArrayOfCourse
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 255, // ArrayOfCourse
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 322, // Course
                    KeyNameIndex = -1,
                    ItemNameIndex = 322, // Course
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Course, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 348, // ArrayOfDeadline
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 348, // ArrayOfDeadline
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 348, // ArrayOfDeadline
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, Public" +
                                    "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, Public" +
                                    "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 364, // Deadline
                    KeyNameIndex = -1,
                    ItemNameIndex = 364, // Deadline
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Deadline, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 373, // ArrayOfAnnounce
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 373, // ArrayOfAnnounce
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 373, // ArrayOfAnnounce
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, Public" +
                                    "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, Public" +
                                    "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 389, // Announce
                    KeyNameIndex = -1,
                    ItemNameIndex = 389, // Announce
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Announce, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // ArrayOfEvent
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 438, // ArrayOfEvent
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 438, // ArrayOfEvent
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Timetable, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Timetable, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    CollectionItemNameIndex = 451, // Event
                    KeyNameIndex = -1,
                    ItemNameIndex = 451, // Event
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Event, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 485, // ArrayOfResultlist
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 485, // ArrayOfResultlist
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 485, // ArrayOfResultlist
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist[], ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist[], ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    CollectionItemNameIndex = 503, // Resultlist
                    KeyNameIndex = -1,
                    ItemNameIndex = 503, // Resultlist
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.Resultlist, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 613, // ArrayOfRecordList
                        NamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        StableNameIndex = 613, // ArrayOfRecordList
                        StableNameNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        TopLevelElementNameIndex = 613, // ArrayOfRecordList
                        TopLevelElementNamespaceIndex = 269, // http://schemas.datacontract.org/2004/07/ClassLibrary
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 631, // RecordList
                    KeyNameIndex = -1,
                    ItemNameIndex = 631, // RecordList
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ClassLibrary.RecordList, ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 655, // ArrayOfanyType
                        NamespaceIndex = 670, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 655, // ArrayOfanyType
                        StableNameNamespaceIndex = 670, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 655, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 670, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=24
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type4.WriteArrayOfCourseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type3.ReadArrayOfCourseFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type5.ReadArrayOfCourseFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type9.WriteCourseToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type8.ReadCourseFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type13.WriteSemestersToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type12.ReadSemestersFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteSemesterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadSemesterFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type22.WriteArrayOfDeadlineToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type21.ReadArrayOfDeadlineFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type23.ReadArrayOfDeadlineFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type27.WriteDeadlineToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type26.ReadDeadlineFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type32.WriteArrayOfAnnounceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type31.ReadArrayOfAnnounceFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type33.ReadArrayOfAnnounceFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type37.WriteAnnounceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type36.ReadAnnounceFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type41.WriteSemestersRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type40.ReadSemestersRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteCurrentteachingweekToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadCurrentteachingweekFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type50.WriteArrayOfEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type49.ReadArrayOfEventFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type51.ReadArrayOfEventFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type55.WriteEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type54.ReadEventFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type59.WriteCourseAssignmentsRootobjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type58.ReadCourseAssignmentsRootobjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type64.WriteArrayOfResultlistToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type63.ReadArrayOfResultlistFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type65.ReadArrayOfResultlistFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type69.WriteResultlistToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type68.ReadResultlistFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type73.WriteCoursehomeworkinfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type72.ReadCoursehomeworkinfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type77.WriteCoursehomeworkrecordToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type76.ReadCoursehomeworkrecordFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type81.WriteResourcesmappingbyhomewkaffixToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type80.ReadResourcesmappingbyhomewkaffixFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type85.WriteAncRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type84.ReadAncRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type89.WritePaginationListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type88.ReadPaginationListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type94.WriteArrayOfRecordListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type93.ReadArrayOfRecordListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type95.ReadArrayOfRecordListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type99.WriteRecordListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type98.ReadRecordListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type103.WriteCourseNoticeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type102.ReadCourseNoticeFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type108.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type107.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type109.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','r','r','a','y','O','f','C','o','u','r','s','e','\0','h',
            't','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g',
            '/','2','0','0','4','/','0','7','/','C','l','a','s','s','L','i','b','r','a','r','y','\0','C','o','u','r','s','e','\0','S',
            'e','m','e','s','t','e','r','s','\0','S','e','m','e','s','t','e','r','\0','A','r','r','a','y','O','f','D','e','a','d','l',
            'i','n','e','\0','D','e','a','d','l','i','n','e','\0','A','r','r','a','y','O','f','A','n','n','o','u','n','c','e','\0','A',
            'n','n','o','u','n','c','e','\0','S','e','m','e','s','t','e','r','s','R','o','o','t','O','b','j','e','c','t','\0','C','u',
            'r','r','e','n','t','t','e','a','c','h','i','n','g','w','e','e','k','\0','A','r','r','a','y','O','f','E','v','e','n','t',
            '\0','E','v','e','n','t','\0','C','o','u','r','s','e','A','s','s','i','g','n','m','e','n','t','s','R','o','o','t','o','b',
            'j','e','c','t','\0','A','r','r','a','y','O','f','R','e','s','u','l','t','l','i','s','t','\0','R','e','s','u','l','t','l',
            'i','s','t','\0','C','o','u','r','s','e','h','o','m','e','w','o','r','k','i','n','f','o','\0','C','o','u','r','s','e','h',
            'o','m','e','w','o','r','k','r','e','c','o','r','d','\0','R','e','s','o','u','r','c','e','s','m','a','p','p','i','n','g',
            'b','y','h','o','m','e','w','k','a','f','f','i','x','\0','A','n','c','R','o','o','t','O','b','j','e','c','t','\0','P','a',
            'g','i','n','a','t','i','o','n','L','i','s','t','\0','A','r','r','a','y','O','f','R','e','c','o','r','d','L','i','s','t',
            '\0','R','e','c','o','r','d','L','i','s','t','\0','C','o','u','r','s','e','N','o','t','i','c','e','\0','A','r','r','a','y',
            'O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o',
            's','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n',
            '/','A','r','r','a','y','s','\0','i','d','\0','i','s','N','e','w','\0','n','a','m','e','\0','s','e','m','e','s','t','e','r',
            '\0','c','u','r','r','e','n','t','S','e','m','e','s','t','e','r','\0','n','e','x','t','S','e','m','e','s','t','e','r','\0',
            'e','n','d','D','a','t','e','\0','s','e','m','e','s','t','e','r','E','n','a','m','e','\0','s','e','m','e','s','t','e','r',
            'N','a','m','e','\0','s','t','a','r','t','D','a','t','e','\0','c','o','u','r','s','e','\0','c','o','u','r','s','e','i','d',
            '\0','d','d','l','\0','d','e','t','a','i','l','\0','h','a','s','B','e','e','n','F','i','n','i','s','h','e','d','\0','I','s',
            'f','i','n','i','s','h','e','d','\0','c','o','u','r','s','e','I','d','\0','o','w','n','e','r','\0','r','e','g','D','a','t',
            'e','\0','t','i','t','l','e','\0','c','u','r','r','e','n','t','D','a','t','e','\0','c','u','r','r','e','n','t','T','e','a',
            'c','h','i','n','g','W','e','e','k','\0','b','e','g','i','n','D','a','t','e','\0','s','e','m','e','s','t','e','r','I','d',
            '\0','t','e','a','c','h','i','n','g','W','e','e','k','I','d','\0','w','e','e','k','N','a','m','e','\0','d','d','\0','f','l',
            '\0','g','r','r','l','I','D','\0','j','s','s','j','\0','k','s','s','j','\0','n','q','\0','n','r','\0','s','f','S','j','t','z',
            '\0','s','k','j','c','\0','s','m','\0','m','e','s','s','a','g','e','\0','r','e','s','u','l','t','L','i','s','t','\0','c','o',
            'u','r','s','e','H','o','m','e','w','o','r','k','I','n','f','o','\0','c','o','u','r','s','e','H','o','m','e','w','o','r',
            'k','R','e','c','o','r','d','\0','a','n','s','w','e','r','D','a','t','e','\0','a','n','s','w','e','r','D','e','t','a','i',
            'l','\0','a','n','s','w','e','r','L','i','n','k','\0','a','n','s','w','e','r','L','i','n','k','F','i','l','e','n','a','m',
            'e','\0','c','o','u','r','s','e','K','n','o','w','l','e','d','g','e','\0','c','o','u','r','s','e','S','o','u','r','c','e',
            '\0','h','o','m','e','w','k','A','f','f','i','x','\0','h','o','m','e','w','k','A','f','f','i','x','F','i','l','e','n','a',
            'm','e','\0','h','o','m','e','w','k','G','r','o','u','p','N','u','m','\0','h','o','m','e','w','k','I','d','\0','h','o','m',
            'e','w','k','I','n','d','e','x','\0','j','i','a','o','e','d','\0','n','o','t','e','I','d','\0','w','e','i','J','i','a','o',
            '\0','y','i','J','i','a','o','\0','y','i','P','i','\0','y','i','Y','u','e','\0','g','r','a','d','e','U','s','e','r','\0','g',
            'r','o','u','p','I','d','\0','g','r','o','u','p','N','a','m','e','\0','h','o','m','e','w','k','D','e','t','a','i','l','\0',
            'i','f','D','e','l','a','y','\0','i','f','f','i','n','e','\0','m','a','r','k','\0','r','e','p','l','y','D','a','t','e','\0',
            'r','e','p','l','y','D','e','t','a','i','l','\0','r','e','s','o','u','r','c','e','s','M','a','p','p','i','n','g','B','y',
            'H','o','m','e','w','k','A','f','f','i','x','\0','r','e','s','o','u','r','c','e','s','M','a','p','p','i','n','g','B','y',
            'R','e','p','l','y','A','f','f','i','x','\0','s','e','q','I','d','\0','s','t','a','t','u','s','\0','s','t','u','d','e','n',
            't','I','d','\0','t','e','a','c','h','e','r','I','d','\0','b','r','o','w','s','e','N','u','m','\0','d','i','s','k','I','d',
            '\0','d','o','w','n','l','o','a','d','N','u','m','\0','d','o','w','n','l','o','a','d','U','r','l','\0','e','x','t','e','n',
            's','i','o','n','\0','f','i','l','e','I','d','\0','f','i','l','e','N','a','m','e','\0','f','i','l','e','S','i','z','e','\0',
            'p','l','a','y','U','r','l','\0','r','e','s','o','u','r','c','e','s','I','d','\0','r','e','s','o','u','r','c','e','s','S',
            't','a','t','u','s','\0','u','s','e','r','C','o','d','e','\0','p','a','g','i','n','a','t','i','o','n','L','i','s','t','\0',
            'c','u','r','r','e','n','t','P','a','g','e','\0','c','u','r','r','e','n','t','P','a','g','e','S','t','r','\0','p','a','g',
            'e','M','a','x','\0','p','a','g','e','S','i','z','e','\0','p','a','g','e','S','t','a','r','t','\0','r','e','c','o','r','d',
            'C','o','u','n','t','\0','r','e','c','o','r','d','C','o','u','n','t','S','t','r','\0','r','e','c','o','r','d','L','i','s',
            't','\0','c','o','u','r','s','e','N','o','t','i','c','e','\0','b','r','o','w','s','e','T','i','m','e','s','\0','m','s','g',
            'P','r','i','o','r','i','t','y','\0'};
    }
}
