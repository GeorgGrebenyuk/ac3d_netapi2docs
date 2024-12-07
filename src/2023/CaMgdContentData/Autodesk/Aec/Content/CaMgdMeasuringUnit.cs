using System;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000034 RID: 52
	public enum CaMgdMeasuringUnit
	{
		// Token: 0x0400033C RID: 828
		MeasuringUnit_Unknown,
		// Token: 0x0400033D RID: 829
		MeasuringUnit_Angstroem = 1001,
		// Token: 0x0400033E RID: 830
		MeasuringUnit_AstronomicalUnit,
		// Token: 0x0400033F RID: 831
		MeasuringUnit_Centimeter,
		// Token: 0x04000340 RID: 832
		MeasuringUnit_Decameter,
		// Token: 0x04000341 RID: 833
		MeasuringUnit_Decimeter,
		// Token: 0x04000342 RID: 834
		MeasuringUnit_Foot,
		// Token: 0x04000343 RID: 835
		MeasuringUnit_Gigameter,
		// Token: 0x04000344 RID: 836
		MeasuringUnit_Hectometer,
		// Token: 0x04000345 RID: 837
		MeasuringUnit_Inch,
		// Token: 0x04000346 RID: 838
		MeasuringUnit_Kilometer,
		// Token: 0x04000347 RID: 839
		MeasuringUnit_Lightyear,
		// Token: 0x04000348 RID: 840
		MeasuringUnit_Meter,
		// Token: 0x04000349 RID: 841
		MeasuringUnit_Microfoot,
		// Token: 0x0400034A RID: 842
		MeasuringUnit_Micrometer,
		// Token: 0x0400034B RID: 843
		MeasuringUnit_Mile,
		// Token: 0x0400034C RID: 844
		MeasuringUnit_Millimeter,
		// Token: 0x0400034D RID: 845
		MeasuringUnit_Millifoot,
		// Token: 0x0400034E RID: 846
		MeasuringUnit_Nanometer,
		// Token: 0x0400034F RID: 847
		MeasuringUnit_Parsec,
		// Token: 0x04000350 RID: 848
		MeasuringUnit_Yard,
		// Token: 0x04000351 RID: 849
		MeasuringUnit_BenoitChain,
		// Token: 0x04000352 RID: 850
		MeasuringUnit_BenoitFoot,
		// Token: 0x04000353 RID: 851
		MeasuringUnit_BenoitLink,
		// Token: 0x04000354 RID: 852
		MeasuringUnit_BenoitMile,
		// Token: 0x04000355 RID: 853
		MeasuringUnit_BenoitYard,
		// Token: 0x04000356 RID: 854
		MeasuringUnit_Chain,
		// Token: 0x04000357 RID: 855
		MeasuringUnit_ClarkeChain,
		// Token: 0x04000358 RID: 856
		MeasuringUnit_ClarkeFoot,
		// Token: 0x04000359 RID: 857
		MeasuringUnit_ClarkeLink,
		// Token: 0x0400035A RID: 858
		MeasuringUnit_ClarkeMile,
		// Token: 0x0400035B RID: 859
		MeasuringUnit_ClarkeYard,
		// Token: 0x0400035C RID: 860
		MeasuringUnit_Fathom,
		// Token: 0x0400035D RID: 861
		MeasuringUnit_Furlong,
		// Token: 0x0400035E RID: 862
		MeasuringUnit_IndianChain,
		// Token: 0x0400035F RID: 863
		MeasuringUnit_IndianFoot,
		// Token: 0x04000360 RID: 864
		MeasuringUnit_IndianLink,
		// Token: 0x04000361 RID: 865
		MeasuringUnit_IndianMile,
		// Token: 0x04000362 RID: 866
		MeasuringUnit_IndianYard,
		// Token: 0x04000363 RID: 867
		MeasuringUnit_Link,
		// Token: 0x04000364 RID: 868
		MeasuringUnit_ModifiedAmericanChain,
		// Token: 0x04000365 RID: 869
		MeasuringUnit_ModifiedAmericanFoot,
		// Token: 0x04000366 RID: 870
		MeasuringUnit_ModifiedAmericanLink,
		// Token: 0x04000367 RID: 871
		MeasuringUnit_ModifiedAmericanMile,
		// Token: 0x04000368 RID: 872
		MeasuringUnit_ModifiedAmericanYard,
		// Token: 0x04000369 RID: 873
		MeasuringUnit_NauticalMile,
		// Token: 0x0400036A RID: 874
		MeasuringUnit_NauticalMileUK,
		// Token: 0x0400036B RID: 875
		MeasuringUnit_Rod,
		// Token: 0x0400036C RID: 876
		MeasuringUnit_SearsChain,
		// Token: 0x0400036D RID: 877
		MeasuringUnit_SearsFoot,
		// Token: 0x0400036E RID: 878
		MeasuringUnit_SearsLink,
		// Token: 0x0400036F RID: 879
		MeasuringUnit_SearsMile,
		// Token: 0x04000370 RID: 880
		MeasuringUnit_SearsYard,
		// Token: 0x04000371 RID: 881
		MeasuringUnit_SurveyChain,
		// Token: 0x04000372 RID: 882
		MeasuringUnit_SurveyFoot,
		// Token: 0x04000373 RID: 883
		MeasuringUnit_SurveyLink,
		// Token: 0x04000374 RID: 884
		MeasuringUnit_SurveyMile,
		// Token: 0x04000375 RID: 885
		MeasuringUnit_SurveyYard,
		// Token: 0x04000376 RID: 886
		MeasuringUnit_SquareAngstroem = 2001,
		// Token: 0x04000377 RID: 887
		MeasuringUnit_SquareAstronomicalUnit,
		// Token: 0x04000378 RID: 888
		MeasuringUnit_SquareCentimeter,
		// Token: 0x04000379 RID: 889
		MeasuringUnit_SquareDecameter,
		// Token: 0x0400037A RID: 890
		MeasuringUnit_SquareDecimeter,
		// Token: 0x0400037B RID: 891
		MeasuringUnit_SquareFoot,
		// Token: 0x0400037C RID: 892
		MeasuringUnit_SquareGigameter,
		// Token: 0x0400037D RID: 893
		MeasuringUnit_SquareHectometer,
		// Token: 0x0400037E RID: 894
		MeasuringUnit_SquareInch,
		// Token: 0x0400037F RID: 895
		MeasuringUnit_SquareKilometer,
		// Token: 0x04000380 RID: 896
		MeasuringUnit_SquareLightyear,
		// Token: 0x04000381 RID: 897
		MeasuringUnit_SquareMeter,
		// Token: 0x04000382 RID: 898
		MeasuringUnit_SquareMicrofoot,
		// Token: 0x04000383 RID: 899
		MeasuringUnit_SquareMicrometer,
		// Token: 0x04000384 RID: 900
		MeasuringUnit_SquareMile,
		// Token: 0x04000385 RID: 901
		MeasuringUnit_SquareMillimeter,
		// Token: 0x04000386 RID: 902
		MeasuringUnit_SquareMillifoot,
		// Token: 0x04000387 RID: 903
		MeasuringUnit_SquareNanometer,
		// Token: 0x04000388 RID: 904
		MeasuringUnit_SquareParsec,
		// Token: 0x04000389 RID: 905
		MeasuringUnit_SquareYard,
		// Token: 0x0400038A RID: 906
		MeasuringUnit_SquareBenoitChain,
		// Token: 0x0400038B RID: 907
		MeasuringUnit_SquareBenoitFoot,
		// Token: 0x0400038C RID: 908
		MeasuringUnit_SquareBenoitLink,
		// Token: 0x0400038D RID: 909
		MeasuringUnit_SquareBenoitMile,
		// Token: 0x0400038E RID: 910
		MeasuringUnit_SquareBenoitYard,
		// Token: 0x0400038F RID: 911
		MeasuringUnit_SquareChain,
		// Token: 0x04000390 RID: 912
		MeasuringUnit_SquareClarkeChain,
		// Token: 0x04000391 RID: 913
		MeasuringUnit_SquareClarkeFoot,
		// Token: 0x04000392 RID: 914
		MeasuringUnit_SquareClarkeLink,
		// Token: 0x04000393 RID: 915
		MeasuringUnit_SquareClarkeMile,
		// Token: 0x04000394 RID: 916
		MeasuringUnit_SquareClarkeYard,
		// Token: 0x04000395 RID: 917
		MeasuringUnit_SquareFathom,
		// Token: 0x04000396 RID: 918
		MeasuringUnit_SquareFurlong,
		// Token: 0x04000397 RID: 919
		MeasuringUnit_SquareIndianChain,
		// Token: 0x04000398 RID: 920
		MeasuringUnit_SquareIndianFoot,
		// Token: 0x04000399 RID: 921
		MeasuringUnit_SquareIndianLink,
		// Token: 0x0400039A RID: 922
		MeasuringUnit_SquareIndianMile,
		// Token: 0x0400039B RID: 923
		MeasuringUnit_SquareIndianYard,
		// Token: 0x0400039C RID: 924
		MeasuringUnit_SquareLink,
		// Token: 0x0400039D RID: 925
		MeasuringUnit_SquareModifiedAmericanChain,
		// Token: 0x0400039E RID: 926
		MeasuringUnit_SquareModifiedAmericanFoot,
		// Token: 0x0400039F RID: 927
		MeasuringUnit_SquareModifiedAmericanLink,
		// Token: 0x040003A0 RID: 928
		MeasuringUnit_SquareModifiedAmericanMile,
		// Token: 0x040003A1 RID: 929
		MeasuringUnit_SquareModifiedAmericanYard,
		// Token: 0x040003A2 RID: 930
		MeasuringUnit_SquareNauticalMile,
		// Token: 0x040003A3 RID: 931
		MeasuringUnit_SquareNauticalMileUK,
		// Token: 0x040003A4 RID: 932
		MeasuringUnit_SquareRod,
		// Token: 0x040003A5 RID: 933
		MeasuringUnit_SquareSearsChain,
		// Token: 0x040003A6 RID: 934
		MeasuringUnit_SquareSearsFoot,
		// Token: 0x040003A7 RID: 935
		MeasuringUnit_SquareSearsLink,
		// Token: 0x040003A8 RID: 936
		MeasuringUnit_SquareSearsMile,
		// Token: 0x040003A9 RID: 937
		MeasuringUnit_SquareSearsYard,
		// Token: 0x040003AA RID: 938
		MeasuringUnit_SquareSurveyChain,
		// Token: 0x040003AB RID: 939
		MeasuringUnit_SquareSurveyFoot,
		// Token: 0x040003AC RID: 940
		MeasuringUnit_SquareSurveyLink,
		// Token: 0x040003AD RID: 941
		MeasuringUnit_SquareSurveyMile,
		// Token: 0x040003AE RID: 942
		MeasuringUnit_SquareSurveyYard,
		// Token: 0x040003AF RID: 943
		MeasuringUnit_Acre = 2900,
		// Token: 0x040003B0 RID: 944
		MeasuringUnit_Are = 2004,
		// Token: 0x040003B1 RID: 945
		MeasuringUnit_Hectare = 2008,
		// Token: 0x040003B2 RID: 946
		MeasuringUnit_DegreeClockwise = 3001,
		// Token: 0x040003B3 RID: 947
		MeasuringUnit_DegreeCounterClockwise,
		// Token: 0x040003B4 RID: 948
		MeasuringUnit_GonClockwise,
		// Token: 0x040003B5 RID: 949
		MeasuringUnit_GonCounterClockwise,
		// Token: 0x040003B6 RID: 950
		MeasuringUnit_RadianClockwise,
		// Token: 0x040003B7 RID: 951
		MeasuringUnit_RadianCounterClockwise,
		// Token: 0x040003B8 RID: 952
		MeasuringUnit_Celsius = 4001,
		// Token: 0x040003B9 RID: 953
		MeasuringUnit_Fahrenheit,
		// Token: 0x040003BA RID: 954
		MeasuringUnit_Kelvin,
		// Token: 0x040003BB RID: 955
		MeasuringUnit_Rankine,
		// Token: 0x040003BC RID: 956
		MeasuringUnit_Dram = 5001,
		// Token: 0x040003BD RID: 957
		MeasuringUnit_Grain,
		// Token: 0x040003BE RID: 958
		MeasuringUnit_Gram,
		// Token: 0x040003BF RID: 959
		MeasuringUnit_Kilogram,
		// Token: 0x040003C0 RID: 960
		MeasuringUnit_LongHundredweight,
		// Token: 0x040003C1 RID: 961
		MeasuringUnit_LongTon,
		// Token: 0x040003C2 RID: 962
		MeasuringUnit_Ounce,
		// Token: 0x040003C3 RID: 963
		MeasuringUnit_Pound,
		// Token: 0x040003C4 RID: 964
		MeasuringUnit_ShortHundredweight,
		// Token: 0x040003C5 RID: 965
		MeasuringUnit_ShortTon,
		// Token: 0x040003C6 RID: 966
		MeasuringUnit_Stone,
		// Token: 0x040003C7 RID: 967
		MeasuringUnit_Tonne,
		// Token: 0x040003C8 RID: 968
		MeasuringUnit_Day = 6001,
		// Token: 0x040003C9 RID: 969
		MeasuringUnit_Hour,
		// Token: 0x040003CA RID: 970
		MeasuringUnit_JulianYear,
		// Token: 0x040003CB RID: 971
		MeasuringUnit_MicroSecond,
		// Token: 0x040003CC RID: 972
		MeasuringUnit_MilliSecond,
		// Token: 0x040003CD RID: 973
		MeasuringUnit_Minute,
		// Token: 0x040003CE RID: 974
		MeasuringUnit_NanoSecond,
		// Token: 0x040003CF RID: 975
		MeasuringUnit_Second,
		// Token: 0x040003D0 RID: 976
		MeasuringUnit_CubicCentimeter = 7003,
		// Token: 0x040003D1 RID: 977
		MeasuringUnit_CubicFoot = 7006,
		// Token: 0x040003D2 RID: 978
		MeasuringUnit_CubicInch = 7009,
		// Token: 0x040003D3 RID: 979
		MeasuringUnit_CubicMeter = 7012,
		// Token: 0x040003D4 RID: 980
		MeasuringUnit_CubicYard = 7020,
		// Token: 0x040003D5 RID: 981
		MeasuringUnit_Litre = 7005,
		// Token: 0x040003D6 RID: 982
		MeasuringUnit_AcreFoot = 7900,
		// Token: 0x040003D7 RID: 983
		MeasuringUnit_GallonUS,
		// Token: 0x040003D8 RID: 984
		MeasuringUnit_GallonUK,
		// Token: 0x040003D9 RID: 985
		MeasuringUnit_Kilovolt = 8001,
		// Token: 0x040003DA RID: 986
		MeasuringUnit_Millivolt,
		// Token: 0x040003DB RID: 987
		MeasuringUnit_Volt,
		// Token: 0x040003DC RID: 988
		MeasuringUnit_Bar = 9001,
		// Token: 0x040003DD RID: 989
		MeasuringUnit_Hectopascal,
		// Token: 0x040003DE RID: 990
		MeasuringUnit_InchMercury,
		// Token: 0x040003DF RID: 991
		MeasuringUnit_Kilopascal,
		// Token: 0x040003E0 RID: 992
		MeasuringUnit_Pascal,
		// Token: 0x040003E1 RID: 993
		MeasuringUnit_Psi,
		// Token: 0x040003E2 RID: 994
		MeasuringUnit_StandardAtmosphere,
		// Token: 0x040003E3 RID: 995
		MeasuringUnit_TechnicalAtmosphere,
		// Token: 0x040003E4 RID: 996
		MeasuringUnit_Torr,
		// Token: 0x040003E5 RID: 997
		MeasuringUnit_Ampere = 10001,
		// Token: 0x040003E6 RID: 998
		MeasuringUnit_MilliAmpere,
		// Token: 0x040003E7 RID: 999
		MeasuringUnit_KiloAmpere,
		// Token: 0x040003E8 RID: 1000
		MeasuringUnit_Gigawatt = 11001,
		// Token: 0x040003E9 RID: 1001
		MeasuringUnit_Kilowatt,
		// Token: 0x040003EA RID: 1002
		MeasuringUnit_Megawatt,
		// Token: 0x040003EB RID: 1003
		MeasuringUnit_Milliwatt,
		// Token: 0x040003EC RID: 1004
		MeasuringUnit_Watt,
		// Token: 0x040003ED RID: 1005
		MeasuringUnit_TonOfRefrigerationInternationalTable,
		// Token: 0x040003EE RID: 1006
		MeasuringUnit_TonOfRefrigeration59DegreeFahrenheit,
		// Token: 0x040003EF RID: 1007
		MeasuringUnit_HorsepowerElectrical,
		// Token: 0x040003F0 RID: 1008
		MeasuringUnit_HorsepowerMetric,
		// Token: 0x040003F1 RID: 1009
		MeasuringUnit_Kilovoltampere = 11900,
		// Token: 0x040003F2 RID: 1010
		MeasuringUnit_Kilovoltamperereactive,
		// Token: 0x040003F3 RID: 1011
		MeasuringUnit_Voltampere,
		// Token: 0x040003F4 RID: 1012
		MeasuringUnit_Voltamperereactive,
		// Token: 0x040003F5 RID: 1013
		MeasuringUnit_Gigajoule = 12001,
		// Token: 0x040003F6 RID: 1014
		MeasuringUnit_Gigawatthour,
		// Token: 0x040003F7 RID: 1015
		MeasuringUnit_Kilojoule,
		// Token: 0x040003F8 RID: 1016
		MeasuringUnit_Kilowatthour,
		// Token: 0x040003F9 RID: 1017
		MeasuringUnit_Joule,
		// Token: 0x040003FA RID: 1018
		MeasuringUnit_Megajoule,
		// Token: 0x040003FB RID: 1019
		MeasuringUnit_Megawatthour,
		// Token: 0x040003FC RID: 1020
		MeasuringUnit_Millijoule,
		// Token: 0x040003FD RID: 1021
		MeasuringUnit_Watthour,
		// Token: 0x040003FE RID: 1022
		MeasuringUnit_BritishThermalUnitInternationalTable,
		// Token: 0x040003FF RID: 1023
		MeasuringUnit_BritishThermalUnit59DegreeFahrenheit,
		// Token: 0x04000400 RID: 1024
		MeasuringUnit_ThermInternationalTable,
		// Token: 0x04000401 RID: 1025
		MeasuringUnit_Therm59DegreeFahrenheit,
		// Token: 0x04000402 RID: 1026
		MeasuringUnit_Gigaohm = 13001,
		// Token: 0x04000403 RID: 1027
		MeasuringUnit_Kiloohm,
		// Token: 0x04000404 RID: 1028
		MeasuringUnit_Megaohm,
		// Token: 0x04000405 RID: 1029
		MeasuringUnit_Milliohm,
		// Token: 0x04000406 RID: 1030
		MeasuringUnit_Ohm,
		// Token: 0x04000407 RID: 1031
		MeasuringUnit_Kilosiemens = 14001,
		// Token: 0x04000408 RID: 1032
		MeasuringUnit_Millisiemens,
		// Token: 0x04000409 RID: 1033
		MeasuringUnit_Siemens,
		// Token: 0x0400040A RID: 1034
		MeasuringUnit_Amperehour = 15001,
		// Token: 0x0400040B RID: 1035
		MeasuringUnit_Coulomb,
		// Token: 0x0400040C RID: 1036
		MeasuringUnit_Kilocoulomb,
		// Token: 0x0400040D RID: 1037
		MeasuringUnit_Milliamperehour,
		// Token: 0x0400040E RID: 1038
		MeasuringUnit_Millicoulomb,
		// Token: 0x0400040F RID: 1039
		MeasuringUnit_Farad = 16001,
		// Token: 0x04000410 RID: 1040
		MeasuringUnit_Microfarad,
		// Token: 0x04000411 RID: 1041
		MeasuringUnit_Millifarad,
		// Token: 0x04000412 RID: 1042
		MeasuringUnit_Nanofarad,
		// Token: 0x04000413 RID: 1043
		MeasuringUnit_Picofarad,
		// Token: 0x04000414 RID: 1044
		MeasuringUnit_Henry = 17001,
		// Token: 0x04000415 RID: 1045
		MeasuringUnit_Microhenry,
		// Token: 0x04000416 RID: 1046
		MeasuringUnit_Millihenry,
		// Token: 0x04000417 RID: 1047
		MeasuringUnit_Nanohenry,
		// Token: 0x04000418 RID: 1048
		MeasuringUnit_Dyne = 18001,
		// Token: 0x04000419 RID: 1049
		MeasuringUnit_Kilopond,
		// Token: 0x0400041A RID: 1050
		MeasuringUnit_Newton,
		// Token: 0x0400041B RID: 1051
		MeasuringUnit_PoundForce,
		// Token: 0x0400041C RID: 1052
		MeasuringUnit_Poundal,
		// Token: 0x0400041D RID: 1053
		MeasuringUnit_OhmPer1000Foot = 19001,
		// Token: 0x0400041E RID: 1054
		MeasuringUnit_OhmPer1000Yard,
		// Token: 0x0400041F RID: 1055
		MeasuringUnit_OhmPerFoot,
		// Token: 0x04000420 RID: 1056
		MeasuringUnit_OhmPerKilometer,
		// Token: 0x04000421 RID: 1057
		MeasuringUnit_OhmPerMeter,
		// Token: 0x04000422 RID: 1058
		MeasuringUnit_OhmPerMile,
		// Token: 0x04000423 RID: 1059
		MeasuringUnit_NewtonPerKilometer = 20001,
		// Token: 0x04000424 RID: 1060
		MeasuringUnit_NewtonPerMeter,
		// Token: 0x04000425 RID: 1061
		MeasuringUnit_PoundForcePer1000Foot,
		// Token: 0x04000426 RID: 1062
		MeasuringUnit_PoundForcePer1000Yard,
		// Token: 0x04000427 RID: 1063
		MeasuringUnit_PoundForcePerFoot,
		// Token: 0x04000428 RID: 1064
		MeasuringUnit_PoundForcePerMile,
		// Token: 0x04000429 RID: 1065
		MeasuringUnit_KilogramPerKilometer = 21001,
		// Token: 0x0400042A RID: 1066
		MeasuringUnit_KilogramPerMeter,
		// Token: 0x0400042B RID: 1067
		MeasuringUnit_PoundPer1000Foot,
		// Token: 0x0400042C RID: 1068
		MeasuringUnit_PoundPer1000Yard,
		// Token: 0x0400042D RID: 1069
		MeasuringUnit_PoundPerFoot,
		// Token: 0x0400042E RID: 1070
		MeasuringUnit_PoundPerMile,
		// Token: 0x0400042F RID: 1071
		MeasuringUnit_NewtonMeter = 22001,
		// Token: 0x04000430 RID: 1072
		MeasuringUnit_KilogramForceMeter,
		// Token: 0x04000431 RID: 1073
		MeasuringUnit_FootPoundForce,
		// Token: 0x04000432 RID: 1074
		MeasuringUnit_InchPoundForce
	}
}
