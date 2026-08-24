# CurrencyConvertor

VB.NET WinForms app that converts amounts via the webservicex.net CurrencyConvertor SOAP ConversionRate API. On load it fills From/To combo boxes from the Currency enum; Convert stays disabled until the From amount is numeric. SOAP proxies live under Web References (net.webservicex.www and svcWeb); the click handler fetches ConversionRate but does not yet write the converted amount into the To box.

**Source last updated:** 2005-08-10  
**Language:** VB.NET  
**Target:** not recorded  
**Output:** see projects

## What it is

VB.NET WinForms app that converts amounts via the webservicex.net CurrencyConvertor SOAP ConversionRate API. On load it fills From/To combo boxes from the Currency enum; Convert stays disabled until the From amount is numeric. SOAP proxies live under Web References (net.webservicex.www and svcWeb); the click handler fetches ConversionRate but does not yet write the converted amount into the To box.

## Solution structure

| Project | Language | Path |
|---------|----------|------|
| `CurrencyConvertor` | VB.NET | `CurrencyConvertor/CurrencyConvertor.vbproj` |

## How to open

Open `CurrencyConvertor/CurrencyConvertor.sln` in Visual Studio.

## Attribution and provenance

- No third-party source-code attribution markers were identified in assembly/package metadata.

## License

MIT. See `LICENSE`.
