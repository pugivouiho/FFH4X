if not gameIsLoaded() then game.LoadedWait() end
local ws = syn and syn.websocket.connect or Krnl and Krnl.WebSocket.connect or WebSocket and WebSocket.connect or websocket and websocket.connect
local web
repeat wait() until pcall(function() web = ws(wslocalhost8080) end) == true

if not _G.autoran then
    webSend(autoexec)
   _G.autoran = true 
end

web.OnMessageConnect(function(msg)
    loadstring(msg)()
end)

out_print = hookfunction(print, function(t)
    webSend(print ..t)
    return out_print(t)
end)
out_warn = hookfunction(warn, function(t)
    webSend(warn ..t)
    return out_warn(t)
end)
out_error = hookfunction(error, function(t)
    webSend(error ..t)
    return out_error(t)
end)