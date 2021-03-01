# szkchm-azdev-t3-frontend2





## Configuration

Set API URL in `Pages/FetchPersonsData.razor`
```cs
protected override async Task OnInitializedAsync()
{
    persons = await Http.GetFromJsonAsync<Person[]>("https://WEB_APP_NAME.azurewebsites.net/users");
}
```

## Commands
```bash
dotnet watch run
```