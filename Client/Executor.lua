if not game:IsLoaded() then game.Loaded:Wait() end
local ws = syn and syn.websocket.connect or Krnl and Krnl.WebSocket.connect or WebSocket and WebSocket.connect or websocket and websocket.connect
local web
repeat wait() until pcall(function() web = ws("ws://localhost:8080") end) == true

if not _G.autoran then
    web:Send("autoexec")
   _G.autoran = true 
end

web.OnMessage:Connect(function(msg)
    xpcall(loadstring(msg), warn)
end)

out_print = hookfunction(print, function(t)
    web:Send("print "..t)
    return out_print(t)
end)
out_warn = hookfunction(warn, function(t)
    web:Send("warn "..t)
    return out_warn(t)
end)
out_error = hookfunction(error, function(t)
    web:Send("error "..t)
    return out_error(t)
end)