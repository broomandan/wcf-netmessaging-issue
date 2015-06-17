# wcf-netmessaging-issue, Steps to reproduce the issue
## Configuration

1. Create a serviceBus namespace
2. Create a queue in your service bus namespace
3. Update configuration file (App.Config) in the WCFServiceWithAzureServiceBusQueue.Host with above generated ServiceBus and queue settings
  1. line 67,68 with Shared Access Signature information
  2. line 85 service endpoint address and queue name

## Execution
1. Set WCFServiceWithAzureServiceBusQueue.Host as StartUp project and hit F5
2. Stop the running service (After following instructions on console which is hitting Enter key few times)
3. Open generated trace log file trace-log.svclog from bin folder
4. Observe exception ypon stopping the service
