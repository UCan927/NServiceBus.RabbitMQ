﻿namespace NServiceBus.Transports.RabbitMQ.Tests.ConnectionString
{
    using System;
    using Config;
    using NUnit.Framework;
    using Settings;

    [TestFixture]
    public class ConnectionConfigurationTests
    {
        ConnectionConfiguration defaults;

        [SetUp]
        public void Setup()
        {
            var settings = new SettingsHolder();
            settings.Set<NServiceBus.Routing.EndpointName>(new NServiceBus.Routing.EndpointName("endpoint"));

            defaults = new ConnectionConfiguration(settings);
        }

        [Test]
        public void Should_not_set_default_host()
        {
            Assert.AreEqual(defaults.Host, null);
        }

        [Test]
        public void Should_set_default_port()
        {
            Assert.AreEqual(defaults.Port, 5672);
        }

        [Test]
        public void Should_set_default_virtual_host()
        {
            Assert.AreEqual(defaults.VirtualHost, "/");
        }

        [Test]
        public void Should_set_default_username()
        {
            Assert.AreEqual(defaults.UserName, "guest");
        }

        [Test]
        public void Should_set_default_password()
        {
            Assert.AreEqual(defaults.Password, "guest");
        }

        [Test]
        public void Should_set_default_requested_heartbeat()
        {
            Assert.AreEqual(defaults.RequestedHeartbeat, 5);
        }

        [Test]
        public void Should_set_default_use_publisher_confirms()
        {
            Assert.AreEqual(defaults.UsePublisherConfirms, true);
        }

        [Test]
        public void Should_set_default_max_wait_time_for_confirms()
        {
            Assert.AreEqual(defaults.MaxWaitTimeForConfirms, TimeSpan.FromSeconds(30));
        }

        [Test]
        public void Should_set_default_retry_delay()
        {
            Assert.AreEqual(defaults.RetryDelay, TimeSpan.FromSeconds(10));
        }
    }
}
