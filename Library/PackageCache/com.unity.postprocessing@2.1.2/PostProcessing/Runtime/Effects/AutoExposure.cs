  a  \          2018.3.0f2 ţ˙˙˙      ˙˙3$řĚuńě˛e+ Í=   ^          7  ˙˙˙˙         Ś ˛            Đ                 Ś                Ś                Ś #               Ś +               H 3   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ      	        Q  j     
        H <   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             Ő I   ˙˙˙˙       1  1  ˙˙˙˙    Ŕ    Ţ               H j  ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j              P             AssetMetaData guid data[0] data[1] data[2] data[3] pathName originalName labels assetStoreRef    ˙˙TMäb&H˛ăr˘3Ĺ!>   ß          7  ˙˙˙˙         Ś ˛               E            Ţ  #             . ,             5   a            Ţ  #             . ,              r            Ţ  #      	       . ,      
       H Ť ˙˙˙˙     1  1  ˙˙˙˙   @   Ţ             Q  j            ń  J   ˙˙˙˙       1  1  ˙˙˙˙        Ţ                j  ˙˙˙˙        \     ˙˙˙˙        H r   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             H w   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             H    ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             y 
              Ţ  #      !       . ,      "       Ő    ˙˙˙˙#       1  1  ˙˙˙˙$    Ŕ    Ţ      %          j  ˙˙˙˙&        H   ˙˙˙˙'       1  1  ˙˙˙˙(   @    Ţ      )        Q  j     *        y 
    +         Ţ  #      ,       . ,      -               .    @    ž ¨      /    @    Ţ  #      0       . ,      1       H ­   ˙˙˙˙2      1  1  ˙˙˙˙3   @    Ţ      4        Q  j     5        H ¸   ˙˙˙˙6      1  1  ˙˙˙˙7   @    Ţ      8        Q  j     9        H Ę   ˙˙˙˙:      1  1  ˙˙˙˙;   @    Ţ      <        Q  j     =      MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙         Ś ˛                E            Ţ               .              (   a            Ţ               .               r            Ţ        	       .       
       H Ť ˙˙˙˙     1  1  ˙˙˙˙   @   Ţ             Q  j            H ę ˙˙˙˙      1  1  ˙˙˙˙   @    Ţ              Q  j             ń  =   ˙˙˙˙      1  1  ˙˙˙˙       Ţ               j  ˙˙˙˙       H   ˙˙˙˙      1  1  ˙˙˙˙   @    Ţ              Q  j             y 
            Ţ               .              y Q               Ţ               .               Ţ  X      !        H i   ˙˙˙˙"      1  1  ˙˙˙˙#   @    Ţ      $        Q  j     %        H u   ˙˙˙˙&      1  1  ˙˙˙˙'   @    Ţ      (        Q  j     )      PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                                 P      ŕyŻ     Ř                                                                                                                                                                                                                                                                                                                                                                                                                                O|c6HčĂDźé\   Packages/com.unity.analytics/Tests/Editor/Unity.Analytics.StandardEvents/StoreOpenedTests.cs                                                                                                                                               StoreOpenedTests  using System.Collections.Generic;
using NUnit.Framework;

namespace UnityEngine.Analytics.Tests
{
    public partial class AnalyticsEventTests
    {
        [Test]
        public void StoreOpened_StoreTypeTest(
            [Values(StoreType.Premium, StoreType.Soft)] StoreType storeType
            )
        {
            Assert.DoesNotThrow(() => m_Result = AnalyticsEvent.StoreOpened(storeType));
            EvaluateAnalyticsResult(m_Result);
        }

        [Test]
        public void StoreOpened_CustomDataTest()
        {
            var storeType = StoreType.Soft;

            Assert.DoesNotThrow(() => m_Result = AnalyticsEvent.StoreOpened(storeType, m_CustomData));
            EvaluateCustomData(m_CustomData);
            EvaluateAnalyticsResult(m_Result);
        }
    }
}
                        StoreOpenedTests                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          a  Ź          2018.3.0f2 ţ˙˙˙      ˙˙3$řĚuńě˛e+ Í=   ^          7  ˙˙˙˙         Ś ˛            Đ                 Ś                Ś                Ś #               Ś +               H 3   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ      	        Q  j     
        H <   ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j             Ő I   ˙˙˙˙       1  1  ˙˙˙˙    Ŕ    Ţ               H j  ˙˙˙˙       1  1  ˙˙˙˙   @    Ţ              Q  j              P             AssetMetaData guid data[0] data[1] data[2] data[3] pathName originalName labels assetStoreRef 
   ˙˙2řžQfV;}`ÜÍÇřwU0   Ň          7  ˙˙˙˙         Ś ˛               E       