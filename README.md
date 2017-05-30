# HelpersPack

## Extensions

###### ContainsOneOf
````C#
var names = (new["Kamil", "Krzysztof", "Wiesio"]).ToList();
var containsOneOf = names.ContainsOneOf("Monika", "Kamil");
````

###### IsOneOf
````C#
var commandResult = AdvResultCode.NotOK;
commandResult.IsOneOf(AdvResultCode.OK, AdvResultCode.AlreadyExists);
````

###### SerializeObject
````C#
var newUser = new UserDTO()
{
    Login = login,
    Ghost = false,
    WhenAdded = DateTime.Now,
    Salt = Guid.NewGuid().ToString("N")
};

var userInXml = newUser.SerializeObject();
````

###### DeserializeObject
````C#
UserDTO deserializedUser = userInXml.DeserializeObject<UserDTO>() as UserDTO;
````

## Templates

#### For WCF

###### GenericRequest / GenericResponse

This two classes can be used to decorate model with some default fields like request status (isOk) or error message.

````C#
GenericResponse<PluginModel> AddPlugin(GenericRequest<PluginModel> request);
````