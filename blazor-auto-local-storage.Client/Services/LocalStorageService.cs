using blazor_auto_local_storage.Client.Interfaces;

namespace blazor_auto_local_storage.Client.Services;

public class LocalStorageService(Blazored.LocalStorage.ILocalStorageService localStorageService) : ILocalStorageService
{
    public async Task SetItemAsync<T>(string key, T value) =>
        await localStorageService.SetItemAsync(key, value);

    public async Task<T?> GetItemAsync<T>(string key) =>
        await localStorageService.GetItemAsync<T>(key);

    public async Task RemoveItemAsync(string key) =>
        await localStorageService.RemoveItemAsync(key);

    public async Task ClearAsync() =>
        await localStorageService.ClearAsync();
}
