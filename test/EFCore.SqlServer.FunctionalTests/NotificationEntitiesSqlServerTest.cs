// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore;

public class NotificationEntitiesSqlServerTest
    : NotificationEntitiesTestBase<NotificationEntitiesSqlServerTest.NotificationEntitiesSqlServerFixture>
{
    public NotificationEntitiesSqlServerTest(NotificationEntitiesSqlServerFixture fixture)
        : base(fixture)
    {
    }

    public class NotificationEntitiesSqlServerFixture : NotificationEntitiesFixtureBase
    {
        protected override ITestStoreFactory TestStoreFactory
            => SqlServerTestStoreFactory.Instance;
    }
}
