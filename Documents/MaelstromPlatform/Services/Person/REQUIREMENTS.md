# Maelstrom Platform
## Person Service
## Requirements

### Functional
| Req. No. | Req. Kind  | Req. Priority | Requirement |
| ---      | ---        | ---           | ---         |
| 1.       | Functional | Must Have     | A person is *anyone* who interacts with the Maelstrom Platform.|
| 2.       | Functional | Must Have     | A person has a profile.|
| 3.       | Functional | Must Have     | A person's profile must include demographic information.|
| 4.       | Functional | Must Have     | A person's demographic information must include information as specified in [Person Demographic Information](#person-demographic-information).|
| 5.       | Functional | Must Have     | A person's profile *may* contain a picture.|
| 6.       | Functional | Must Have     | A person's profile *may* contain a brief biography (a few sentences).|
| 7.       | Functional | Must Have     | A person may view *all* issues that he or she has authored.|
| 9.       | Functional | Must Have     | A person may view *all* documents that he or she has authored.|
| 10.      | Functional | Must Have     | A person may view *all* requirements that he or she has authored.|
| 11.      | Functional | Must Have     | A person may view *all* user stories that he or she has authored.|
| 12.      | Functional | Must Have     | A person may view *all* test cases that he or she has authored.|
| 13.      | Functional | Must Have     | A person may view *all* tasks that he or she has authored.|
| 14.      | Functional | Must Have     | A person may view *all* calendar events that he or she has created.|
| 15.      | Functional | Must Have     | A person may view *all* communication that he or she has created.|
| 16.      | Functional | Must Have     | A person may view *all* discussion that he or she has created.|
| 17.      | Functional | Must Have     | Each person in the Maelstrom Platform must have a *dashboard*.|
| 20.      | Functional | Must Have     | A person's dashboard must include information as specified in [Person Dashboard Information](#person-dashboard-information).|
| 18.      | Functional | Must Have     | Each person in the Maelstrom Platform may have a personal *backlog*.|
| 19.      | Functional | Must Have     | A person may view *all* issues assigned to him or her.|
| 21.      | Functional | Must Have     | A person may view *all* documents assigned to him or her.|
| 22.      | Functional | Must Have     | A person may view *all* requirements assigned to him or her.|
| 23.      | Functional | Must Have     | A person may view *all* user stories assigned to him or her.|
| 24.      | Functional | Must Have     | A person may view *all* test cases assigned to him or her.|
| 25.      | Functional | Must Have     | A person may view *all* tasks assigned to him or her.|
| 26.      | Functional | Must Have     | A person may view *all* communications assigned to him or her.|

### Security
| Req. No. | Req. Kind | Req. Priority | Requirement |
| ---      | ---       | ---           | ---         |
| 1.       | Security  | Must Have     | A person is *anyone* who interacts with the Maelstrom Platform.|
| 2.       | Security  | Must Have     | A person does *not* directly log into and interact with the Maelstrom Platform.|
| 3.       | Security  | Must Have     | An *account* grants access to the Maelstrom Platform and contains information, such as a user name, password, and user role(s).|
| 4.       | Security  | Must Have     | When a person is *created* in the Maelstrom Platform, a default account for that person is also created with a default *user* role.|
| 5.       | Security  | Must Have     | When the Maelstrom Platform is configured for the first time, a default global *administrator* person and account are created.|
| 6.       | Security  | Must Have     | The default administrator account can create other administrator accounts.|
| 5.       | Security  | Must Have     | An account is created by a person (the default account) or through an account.|
| 6.       | Security  | Must Have     | An account is managed by a person through an account.|
| 7.       | Security  | Must Have     | A person can have an unlimited number of accounts.|
| 8.       | Security  | Must Have     | A person logs into the Maelstrom Platform using an account.|
| 9.       | Security  | Must Have     | A person interacts with the Maelstrom Platform through an account.|
| 10.      | Security  | Must Have     | A session is an instance of the Maelstrom Platform opened in a web browser.|
| 11.      | Security  | Must Have     | An account can have an unlimited number of sessions.|
| 12.      | Security  | Must Have     | A person can be logged into the Maelstrom Platform using multiple (any combination of same or different) accounts with each account in a different session.|
| 13.      | Security  | Must Have     | A *role* restricts what Maelstrom Platform features a person through an account can interact with.|
| 13.      | Security  | Must Have     | An account can belong to an unlimited number of roles.|
| 14.      | Security  | Must Have     | Multiple account roles combine to determine the Maelstrom Platform features a person can interact with.|
| 14.      | Security  | Must Have     | A service *item* is an instance of the primary artifact of that service. For example, an issue service item is an issue.|
| 15.      | Security  | Must Have     | A global Creator role must exist that grants the ability to create *all* service items.|
| 16.      | Security  | Must Have     | An account belonging to the global Creator role can create a person.|
| 17.      | Security  | Must Have     | The Person service must have a *Person Creator* role.|
| 18.      | Security  | Must Have     | The Person Creator role is the global Creator role applied to the Person service only.|
| 19.      | Security  | Must Have     | A global *Editor* role must exist that grants the ability to edit *all* service items.|
| 20.      | Security  | Must Have     | The Person service must have a *Person Editor* role.|
| 21.      | Security  | Must Have     | The Person Editor role is the global Editor role applied to the Person service only.|
| 22.      | Security  | Must Have     | A global *Reader* role must exist that grants the ability to view *all* service items.|
| 23.      | Security  | Must Have     | The Person service must have a *Person Reader* role.|
| 24.      | Security  | Must Have     | The Person Reader role is the global Reader role applied to the Person service only.|

### Performance
| Req. No. | Req. Kind   | Req. Priority | Requirement |
| ---      | ---         | ---           | ---         |
| 1.       | Performance | Must Have     | 

### Other Non-Functional
| Req. No. | Req. Kind | Req. Priority | Requirement |
| ---      | ---       | ---           | ---         |
| 1.       | Other     | Must Have     | 

#### Person Demographic Information
* Identity
  * Name prefix
  * First name
  * Middle name or initial
  * Last name
  * Name suffix
  * Date of birth
  * Nickname
* Contact
  * Primary telephone number
  * Zero or more (unlimited) secondary telephone numbers
  * Primary e-mail address
  * Zero or more (unlimited) secondary e-mail addresses
  * Primary address
  * Zero or more (unlimited) secondary addresses
  * Primary social media account user name
  * Zero or more (unlimited) secondary social media account user names
* Security
  * Primary role
  * Zero or more (unlimited) secondary roles

#### Person Dashboard Information
* Count of issues authored
* Count of documents authored
* Count of test cases authored
* Count of tasks authored
* Count of user stories authored
* Count of calendar events created
* Count of discussion topics created
* Count of communication created
* Count of requirements created
* Count of issues assigned
* Count of documents assigned
* Count of test cases assigned
* Count of tasks assigned
* Count of user stories assigned
* Count of communications assigned
* Count of requirements assigned
* 