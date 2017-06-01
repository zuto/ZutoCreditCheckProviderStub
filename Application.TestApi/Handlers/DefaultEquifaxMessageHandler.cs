using System;
using Application.TestApi.Entities;
using Application.TestApi.Modules;

namespace Application.TestApi.Handlers
{
    public class DefaultEquifaxMessageHandler : IHandleDefaultMessages
    {
        #region GoodResponse

        readonly string GoodResponse = @"<soapenv:Envelope xmlns:soapenv=™http://schemas.xmlsoap.org/soap/envelope/™>
   <soapenv:Header>
      <sec:PasswordExpiryInformation xmlns:sec=™http://ewsconsumer.services.uk.equifax.com/schema/v2/security™>
         <PasswordSecurity xmlns=™http://services.uk.equifax.com/schema/v1/security™>
            <mustChangePassword>false</mustChangePassword>
            <passwordValidityPeriod>30</passwordValidityPeriod>
            <latestDateOfPasswordChange>2017-06-16T16:12:21.000+01:00</latestDateOfPasswordChange>
            <lastPasswordChange>2017-05-17T16:12:21.000+01:00</lastPasswordChange>
         </PasswordSecurity>
      </sec:PasswordExpiryInformation>
   </soapenv:Header>
   <soapenv:Body>
      <ns2:creditQuotationSearchResponse xmlns:ns2=™http://ewsconsumer.services.uk.equifax.com/schema/v2/creditsearch/creditquotationsearchresponse™>
         <clientRef>D0511E92-5D47-49AA-824C-AEBD355EABAE</clientRef>
         <nonAddressSpecificData>
            <attributableData accessDenied=™true™/>
            <potentialAssociates accessDenied=™true™/>
            <scores>
               <score sourcedFrom=™SCO™>
                  <scoreLabel>RNOSF01</scoreLabel>
                  <positive>true</positive>
                  <value>264</value>
               </score>
               <score sourcedFrom=™SCO™>
                  <scoreLabel>RNOLF01</scoreLabel>
                  <positive>true</positive>
                  <value>264</value>
               </score>
               <score sourcedFrom=™SCO™>
                  <scoreLabel>RNOLF02</scoreLabel>
                  <positive>true</positive>
                  <value>264</value>
               </score>
               <score sourcedFrom=™SCO™>
                  <scoreLabel>FICCS01</scoreLabel>
                  <positive>true</positive>
                  <value>154</value>
               </score>
            </scores>
            <attributes>
               <attribute>
                  <identifier>A_C13</identifier>
                  <value>N</value>
               </attribute>
               <attribute>
                  <identifier>A_E101</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>A_N101</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>BSC019</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC020</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC023</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC024</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC025</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC034</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC035</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC036</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC044</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC045</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC046</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC052</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC053</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC054</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC060</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC061</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC062</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC410</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC412</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC413</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC415</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC416</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC417</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC418</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC433</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC435</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC436</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC437</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC438</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC439</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC450</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC459</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSC464</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BSE410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BSN410</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>BTC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC416</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC417</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC418</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC435</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC436</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC437</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC444</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC446</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BTC455</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC019</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC020</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC025</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC036</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC044</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC045</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC046</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC054</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC062</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC415</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC418</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC435</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC436</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC437</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAE410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>BAN410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC2</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC8</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC9</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC10</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC14</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC40</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC41</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC42</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC50</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC51</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC52</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC53</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC55</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC66</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC68</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC150</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC151</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC152</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC153</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC250</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC251</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC252</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSC253</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSE67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSN67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CSP1</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CSP3</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CSP13</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CSP22</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CSP54</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CSP65</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CSP67</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTC1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC40</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC50</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC51</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTC67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTE67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN8</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTN67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CTP1</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP3</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP13</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP22</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP40</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP54</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP65</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CTP67</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAC1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC40</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAC67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE40</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAE67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN1</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN3</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN13</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN22</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN40</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN54</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN65</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAN67</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>CAP1</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP3</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP13</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP22</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP40</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP54</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP65</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CAP67</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>CPCF04</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DAC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DAC418</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DAC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DSC410</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>DSC418</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>DSC438</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>DTC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DTC412</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DTC418</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DTC435</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DTC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>EAC14</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>EAC15</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>EAC41</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>EPCF11</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>EPCF12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>ESC14</identifier>
                  <value>13</value>
                  <numericValue>13</numericValue>
               </attribute>
               <attribute>
                  <identifier>ESC15</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>ESC41</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>ETD14</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>ETD15</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>ETD41</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC008</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC009</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC011</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC030</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC121</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC122</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC158</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC159</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC161</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC176</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC318</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC379</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAC381</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAE318</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAN108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAN109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAN111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAN308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAN309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAN311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FAP108</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP109</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP111</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP118</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP308</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP309</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP311</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FAP318</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC008</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC009</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC026</identifier>
                  <value>41</value>
                  <numericValue>41</numericValue>
               </attribute>
               <attribute>
                  <identifier>FSC103</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC104</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC108</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC109</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC111</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC116</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC117</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC118</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC122</identifier>
                  <value>15</value>
                  <numericValue>15</numericValue>
               </attribute>
               <attribute>
                  <identifier>FSC126</identifier>
                  <value>15</value>
                  <numericValue>15</numericValue>
               </attribute>
               <attribute>
                  <identifier>FSC158</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC159</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC160</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC176</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC201</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>FSC202</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>FSC251</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC308</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC309</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC311</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC312</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC316</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC318</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC354</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC358</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC359</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC361</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC365</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC378</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC379</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC381</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSC401</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSE108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSE318</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FSN108</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSN109</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSN111</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSN308</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSN309</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSN311</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP108</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP109</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP111</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP118</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP308</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP309</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP311</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FSP318</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTC008</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC009</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC011</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC022</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC026</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC121</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC122</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC126</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTC318</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTE318</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTN108</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTN109</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTN111</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTN308</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTN309</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTN311</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>FTP108</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP109</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP111</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP118</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP308</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP309</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP311</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>FTP318</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>GAC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>GAC418</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>GAC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>GSC418</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>GSC424</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>GSC438</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>GTC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>GTC418</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>GTC435</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>GTC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HAC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HAC415</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HAC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HSC410</identifier>
                  <value>20</value>
                  <numericValue>20</numericValue>
               </attribute>
               <attribute>
                  <identifier>HSC413</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>HSC415</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>HSC438</identifier>
                  <value>H</value>
                  <reason>Characteristic cannot be calculated</reason>
               </attribute>
               <attribute>
                  <identifier>HTC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HTC415</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HTC435</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>HTC438</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC102</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC546</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC547</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC560</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC596</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC598</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAC599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE204</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE560</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAE599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN250</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAN599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LAP058</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP072</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP073</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP075</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP102</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP172</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP173</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP251</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP556</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP558</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP560</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP595</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP597</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LAP599</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LPCF10</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LPCF20</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSC056</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC058</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC072</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC073</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC075</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC076</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC077</identifier>
                  <value>13</value>
                  <numericValue>13</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC102</identifier>
                  <value>8</value>
                  <numericValue>8</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC157</identifier>
                  <value>11</value>
                  <numericValue>11</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC172</identifier>
                  <value>3808</value>
                  <numericValue>3808</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC173</identifier>
                  <value>7</value>
                  <numericValue>7</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC174</identifier>
                  <value>93</value>
                  <numericValue>93</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC199</identifier>
                  <value>6</value>
                  <numericValue>6</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC204</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC250</identifier>
                  <value>2</value>
                  <numericValue>2</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC251</identifier>
                  <value>99</value>
                  <numericValue>99</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC300</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC326</identifier>
                  <value>12</value>
                  <numericValue>12</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC330</identifier>
                  <value>G</value>
                  <reason>Characteristic is negative</reason>
               </attribute>
               <attribute>
                  <identifier>LSC339</identifier>
                  <value>-2</value>
                  <numericValue>-2</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC340</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC350</identifier>
                  <value>13</value>
                  <numericValue>13</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC424</identifier>
                  <value>8</value>
                  <numericValue>8</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC471</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC472</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC473</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC507</identifier>
                  <value>12</value>
                  <numericValue>12</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC508</identifier>
                  <value>14</value>
                  <numericValue>14</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC509</identifier>
                  <value>7</value>
                  <numericValue>7</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC511</identifier>
                  <value>7</value>
                  <numericValue>7</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC546</identifier>
                  <value>8</value>
                  <numericValue>8</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC547</identifier>
                  <value>15</value>
                  <numericValue>15</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC549</identifier>
                  <value>3</value>
                  <numericValue>3</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC550</identifier>
                  <value>2</value>
                  <numericValue>2</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC551</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC556</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC557</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC558</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC559</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC560</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC595</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC596</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC597</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC598</identifier>
                  <value>100</value>
                  <numericValue>100</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC599</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC617</identifier>
                  <value>19</value>
                  <numericValue>19</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC619</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC621</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC690</identifier>
                  <value>D</value>
               </attribute>
               <attribute>
                  <identifier>LSC940</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC943</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSC945</identifier>
                  <value>12</value>
                  <numericValue>12</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSC958</identifier>
                  <value>19</value>
                  <numericValue>19</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSE058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE102</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE175</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE250</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE251</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE350</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE547</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE560</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE598</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSE617</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LSN058</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN072</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN073</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN075</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN102</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSN172</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN173</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN250</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN251</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN350</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>LSN547</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN556</identifier>
                  <value>S</value>
               </attribute>
               <attribute>
                  <identifier>LSN558</identifier>
                  <value>U</value>
               </attribute>
               <attribute>
                  <identifier>LSN595</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN597</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSN599</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP058</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP072</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP073</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP075</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP102</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP172</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP173</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP175</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP202</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP250</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP251</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP301</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP350</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP546</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP547</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP556</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP558</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP560</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP595</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP597</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP598</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP599</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP617</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LSP943</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTC058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC102</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC175</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC204</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC326</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC330</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC339</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC340</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC471</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC472</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC473</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC546</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC547</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC560</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC596</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC598</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC940</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC943</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTC945</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE102</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE546</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE547</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE560</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTE599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN058</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN072</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN073</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN075</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN076</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN077</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN173</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN556</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN558</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN595</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN597</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTN599</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>LTP058</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP072</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP073</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP075</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP102</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP172</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP173</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP546</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP547</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP556</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP558</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP560</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP595</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP597</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP599</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP617</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP942</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>LTP943</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>MAC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>MAC417</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>MSC410</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>MSC415</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>MSC418</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>MSC454</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>MTC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>MTC413</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>MTC415</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAC138</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAC150</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAC200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAE200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAN200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NAP200</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>NSC110</identifier>
                  <value>20</value>
                  <numericValue>20</numericValue>
               </attribute>
               <attribute>
                  <identifier>NSC138</identifier>
                  <value>H</value>
                  <reason>Characteristic cannot be calculated</reason>
               </attribute>
               <attribute>
                  <identifier>NSC150</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>NSC200</identifier>
                  <value>20</value>
                  <numericValue>20</numericValue>
               </attribute>
               <attribute>
                  <identifier>NSE200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NSE203</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NSE410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NSN200</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>NSN203</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>NSN410</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>NSP200</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>NSP410</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>NTC135</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTC138</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTC200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTC203</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTC310</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTC410</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTE200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTN200</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>NTP200</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>SAC12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SAC4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SAE12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SAE4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SAN12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SAN4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SAP12</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>SAP4</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>SSC1</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>SSC12</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>SSC3</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>SSC4</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>SSE12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SSE4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>SSN12</identifier>
                  <value>1</value>
                  <numericValue>1</numericValue>
               </attribute>
               <attribute>
                  <identifier>SSN4</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>SSP1</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>SSP12</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>SSP4</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>STC12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>STC4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>STE12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>STE4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>STN12</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>STN4</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>STP12</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>STP4</identifier>
                  <value>__</value>
                  <reason>No information supplied for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>TAC118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TAC138</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TSC001</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>TSC002</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>TSC003</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>TSC004</identifier>
                  <value>H</value>
                  <reason>Characteristic cannot be calculated</reason>
               </attribute>
               <attribute>
                  <identifier>TSC101</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>TSC107</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>TSC118</identifier>
                  <value>0</value>
                  <numericValue>0</numericValue>
               </attribute>
               <attribute>
                  <identifier>TSC126</identifier>
                  <value>H</value>
                  <reason>Characteristic cannot be calculated</reason>
               </attribute>
               <attribute>
                  <identifier>TSC135</identifier>
                  <value>H</value>
                  <reason>Characteristic cannot be calculated</reason>
               </attribute>
               <attribute>
                  <identifier>TSC138</identifier>
                  <value>H</value>
                  <reason>Characteristic cannot be calculated</reason>
               </attribute>
               <attribute>
                  <identifier>TSC159</identifier>
                  <value>C</value>
                  <reason>No information qualifies for the calculation</reason>
               </attribute>
               <attribute>
                  <identifier>TTC001</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TTC118</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TTC126</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TTC138</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TTC150</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>TTC159</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF093</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF094</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF160</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF170</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF172</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF175</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF176</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF179</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF181</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>WCF185</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>XPCF02</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>XPCF08</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>XPCF09</identifier>
                  <value>M</value>
                  <reason>No information in that data type</reason>
               </attribute>
               <attribute>
                  <identifier>DUM041</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM042</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM043</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM044</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM045</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM046</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM047</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM048</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM049</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM050</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM001</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM002</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM003</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM004</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM005</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM006</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM007</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM008</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM009</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM010</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM061</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM062</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM063</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM064</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM065</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM066</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM067</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM068</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM069</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM070</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM095</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM096</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM079</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM080</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM081</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM082</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM083</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM084</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM085</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM086</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM097</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM098</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM123</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM124</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM126</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM127</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM140</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM141</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM168</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM122</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM125</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM132</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM133</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM138</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM160</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM161</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM162</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM179</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM180</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM091</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM092</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM071</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM072</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM073</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM074</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM075</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM076</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM077</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM078</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM099</identifier>
                  <value></value>
               </attribute>
               <attribute>
                  <identifier>DUM100</identifier>
                  <value></value>
               </attribute>
            </attributes>
         </nonAddressSpecificData>
         <soleSearch>
            <primary>
               <suppliedAddressData>
                  <addressMatchStatus>singleMatch</addressMatchStatus>
                  <addressSpecificData>
                     <electoralRollData>
                        <electoralRoll sourcedFrom=™ELR™>
                           <name>
                              <middleName>M</middleName>
                              <surname>EDWAEDS</surname>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <seniority>unknown</seniority>
                           <annualRegisterPeriod>
                              <start>2003</start>
                              <end>2017</end>
                           </annualRegisterPeriod>
                        </electoralRoll>
                     </electoralRollData>
                     <fraudProfileSummaryData accessDenied=™true™/>
                     <insightData>
                        <budgetAccount sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>ONE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>ONE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>8</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>9</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>10</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>11</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>12</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>13</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>14</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>15</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>16</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>17</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <companyClass>FS</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>20</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <fixedPaymentTerms>
                              <numberOfPayments>0</numberOfPayments>
                              <paymentAmount>
                                 <amount>46</amount>
                                 <currency>GBP</currency>
                              </paymentAmount>
                           </fixedPaymentTerms>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastUpdateDate>2015-10-06</lastUpdateDate>
                           <paymentFrequency>weekly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2014-03-03</startDate>
                        </budgetAccount>
                        <commsSupplyAccount sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>S</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>8</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>9</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>10</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>11</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>12</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>13</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>14</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>15</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>16</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>17</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>18</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>19</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <companyClass>CS</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2011-05-09</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastUpdateDate>2011-05-23</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2009-09-16</startDate>
                        </commsSupplyAccount>
                        <creditCard sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <companyClass>DC</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>670</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>670</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2013-07-09</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0712</lastDelinquentDate>
                           <lastUpdateDate>2014-04-24</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2012-03-05</startDate>
                        </creditCard>
                        <currentAccount overdraft=™false™ sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <middleName>M</middleName>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>8</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>9</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>10</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>11</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>12</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>13</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>14</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>15</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>16</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>17</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>18</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>19</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>20</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>21</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>22</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>23</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>24</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>25</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>26</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>27</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>28</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>29</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>30</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>31</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>32</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>33</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>34</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>35</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>36</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>37</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>38</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>39</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>40</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>41</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>42</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>43</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>44</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>45</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>46</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>47</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <companyClass>BK</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastUpdateDate>2017-03-29</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2002-10-28</startDate>
                        </currentAccount>
                        <homeLendingAgreement sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <companyClass>DC</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>140</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>140</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2013-12-23</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0113</lastDelinquentDate>
                           <lastUpdateDate>2016-03-15</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2013-06-03</startDate>
                        </homeLendingAgreement>
                        <homeLendingAgreement sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>S</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <companyClass>FS</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2015-02-10</endDate>
                           <fixedPaymentTerms>
                              <numberOfPayments>7</numberOfPayments>
                              <paymentAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </paymentAmount>
                           </fixedPaymentTerms>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastUpdateDate>2015-04-09</lastUpdateDate>
                           <paymentFrequency>weekly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2014-07-11</startDate>
                        </homeLendingAgreement>
                        <homeLendingAgreement sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>S</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>8</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <companyClass>FS</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2015-10-23</endDate>
                           <fixedPaymentTerms>
                              <numberOfPayments>7</numberOfPayments>
                              <paymentAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </paymentAmount>
                           </fixedPaymentTerms>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastUpdateDate>2015-12-08</lastUpdateDate>
                           <paymentFrequency>weekly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2015-02-10</startDate>
                        </homeLendingAgreement>
                        <homeLendingAgreement sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <middleName>M</middleName>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>S</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>THREE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>TWO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>ONE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <companyClass>FN</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>480</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2013-09-23</endDate>
                           <fixedPaymentTerms>
                              <numberOfPayments>7</numberOfPayments>
                              <paymentAmount>
                                 <amount>64</amount>
                                 <currency>GBP</currency>
                              </paymentAmount>
                           </fixedPaymentTerms>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>1012</lastDelinquentDate>
                           <lastUpdateDate>2014-05-21</lastUpdateDate>
                           <paymentFrequency>weekly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2013-05-27</startDate>
                        </homeLendingAgreement>
                        <mailOrderAccount mailOrderType=™standard™ sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <companyClass>DC</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>1277</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>1132</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2013-06-18</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0712</lastDelinquentDate>
                           <lastUpdateDate>2016-05-29</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2012-12-07</startDate>
                        </mailOrderAccount>
                        <mailOrderAccount mailOrderType=™standard™ sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>FIVE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>FOUR</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>THREE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>TWO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>ONE</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>8</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <companyClass>MO</companyClass>
                           <creditLimit suppressed=™false™>
                              <limit>
                                 <amount>100</amount>
                                 <currency>GBP</currency>
                              </limit>
                           </creditLimit>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>177</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>145</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2016-05-18</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0615</lastDelinquentDate>
                           <lastUpdateDate>2016-06-27</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2015-09-17</startDate>
                        </mailOrderAccount>
                        <unsecuredLoan sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <companyClass>DC</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>484</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>360</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2016-03-13</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0415</lastDelinquentDate>
                           <lastUpdateDate>2017-04-02</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2015-09-25</startDate>
                        </unsecuredLoan>
                        <unsecuredLoan sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <companyClass>DC</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>580</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>580</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2016-03-13</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0415</lastDelinquentDate>
                           <lastUpdateDate>2016-08-23</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2015-10-29</startDate>
                        </unsecuredLoan>
                        <unsecuredLoan sourcedFrom=™INR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <middleName>M</middleName>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>D</paymentStatus>
                           </paymentHistory>
                           <companyClass>FS</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>480</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>480</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2013-09-08</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastDelinquentDate>0912</lastDelinquentDate>
                           <lastUpdateDate>2014-06-08</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2013-05-31</startDate>
                        </unsecuredLoan>
                     </insightData>
                     <previousSearches>
                        <previousCreditSearch sourcedFrom=™ASR™>
                           <dob>1981-01-13</dob>
                           <name>
                              <surname>EDWAEDS</surname>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <companyType>CS</companyType>
                           <jointApplicant>false</jointApplicant>
                           <searchDate>2017-05-12</searchDate>
                           <searchType>creditApplication</searchType>
                           <optIn>true</optIn>
                        </previousCreditSearch>
                     </previousSearches>
                  </addressSpecificData>
                  <index>1</index>
                  <inputAddress sourcedFrom=™ADI™>
                     <address>
                        <line>877 CROMWELL ROAD</line>
                        <line>ELY</line>
                        <line>CB6 1AS</line>
                     </address>
                  </inputAddress>
                  <noticeOfCorrectionOrDisputePresent>false</noticeOfCorrectionOrDisputePresent>
                  <matchedAddress sourcedFrom=™ADO™>
                     <address>
                        <county>CAMBS</county>
                        <number>00877</number>
                        <postcode>CB6 1AS</postcode>
                        <postTown>ELY</postTown>
                        <street1>CROMWELL ROAD</street1>
                        <addressID>28030104690</addressID>
                     </address>
                  </matchedAddress>
               </suppliedAddressData>
               <linkedAddressData>
                  <addressMatchStatus>singleMatch</addressMatchStatus>
                  <index>2</index>
                  <linkType>previousFromSuppliedCurrent</linkType>
                  <noticeOfCorrectionOrDisputePresent>false</noticeOfCorrectionOrDisputePresent>
               </linkedAddressData>
               <linkedAddressData>
                  <addressMatchStatus>singleMatch</addressMatchStatus>
                  <addressSpecificData>
                     <insightData>
                        <commsSupplyAccount sourcedFrom=™INV™>
                           <dob>1981-01-13</dob>
                           <name>
                              <middleName>M</middleName>
                              <surname>EDWAEDS</surname>
                              <title>MISS</title>
                              <forename>SAI GOVINDARAJU</forename>
                           </name>
                           <nameMatchStatus>A</nameMatchStatus>
                           <paymentHistory>
                              <ageInMonths>0</ageInMonths>
                              <paymentStatus>S</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>1</ageInMonths>
                              <paymentStatus>N</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>2</ageInMonths>
                              <paymentStatus>N</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>3</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>4</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>5</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>6</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>7</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>8</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>9</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>10</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>11</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>12</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>13</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>14</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>15</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>16</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>17</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>18</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>19</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>20</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>21</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>22</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>23</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>24</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>25</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>26</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>27</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>28</ageInMonths>
                              <paymentStatus>ZERO</paymentStatus>
                           </paymentHistory>
                           <paymentHistory>
                              <ageInMonths>29</ageInMonths>
                              <paymentStatus>U</paymentStatus>
                           </paymentHistory>
                           <companyClass>CS</companyClass>
                           <currentBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </currentBalance>
                           <defaultBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </defaultBalance>
                           <endDate>2014-02-09</endDate>
                           <insightQuality>
                              <qualityIndicator1>false</qualityIndicator1>
                              <qualityIndicator2>false</qualityIndicator2>
                           </insightQuality>
                           <lastUpdateDate>2014-05-26</lastUpdateDate>
                           <paymentFrequency>monthly</paymentFrequency>
                           <startBalance suppressed=™false™>
                              <balanceAmount>
                                 <amount>0</amount>
                                 <currency>GBP</currency>
                              </balanceAmount>
                           </startBalance>
                           <startDate>2011-12-19</startDate>
                        </commsSupplyAccount>
                     </insightData>
                  </addressSpecificData>
                  <index>3</index>
                  <linkType>nextFromSuppliedCurrent</linkType>
                  <noticeOfCorrectionOrDisputePresent>false</noticeOfCorrectionOrDisputePresent>
               </linkedAddressData>
            </primary>
         </soleSearch>
      </ns2:creditQuotationSearchResponse>
   </soapenv:Body>
</soapenv:Envelope>
".Replace("™", "\"");
        #endregion

        #region FaultException

        private string FaultXML = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"">
   <soapenv:Body>
      <soapenv:Fault>
         <faultcode>soapenv:Server</faultcode>
         <faultstring xml:lang=""en"">User authentication error</faultstring>
         <detail>
            <ns2:creditQuotationSearchFault xmlns:ns2=""http://ewsconsumer.services.uk.equifax.com/schema/v2"">
               <code>EWSC0005</code>
               <message>Bad credentials</message>
            </ns2:creditQuotationSearchFault>
         </detail>
      </soapenv:Fault>
   </soapenv:Body>
</soapenv:Envelope>";


        #endregion

        #region MultipleAddresses

        private string multipleAddressXML = @"<soapenv:Envelope xmlns:soapenv=™http://schemas.xmlsoap.org/soap/envelope/™>
   <soapenv:Header>
      <sec:PasswordExpiryInformation xmlns:sec=™http://ewsconsumer.services.uk.equifax.com/schema/v2/security™>
         <PasswordSecurity xmlns=™http://services.uk.equifax.com/schema/v1/security™>
            <mustChangePassword>false</mustChangePassword>
            <passwordValidityPeriod>30</passwordValidityPeriod>
            <latestDateOfPasswordChange>2017-06-16T16:12:21.000+01:00</latestDateOfPasswordChange>
            <lastPasswordChange>2017-05-17T16:12:21.000+01:00</lastPasswordChange>
         </PasswordSecurity>
      </sec:PasswordExpiryInformation>
   </soapenv:Header>
   <soapenv:Body>
      <ns2:creditQuotationSearchResponse xmlns:ns2=™http://ewsconsumer.services.uk.equifax.com/schema/v2/creditsearch/creditquotationsearchresponse™>
         <clientRef>D0511E92-5D47-49AA-824C-AEBD355EABAE</clientRef>
         <soleSearch>
            <primary>
               <suppliedAddressData>
                  <addressMatchStatus>multipleMatch</addressMatchStatus>
                  <index>1</index>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT E 44</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004375</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 1 109</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004176</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 2 316</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004001</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 2 44</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004060</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 3 26</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004160</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 3 49</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004039</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 3A 181</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004430</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 5 11</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004477</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 5 17</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004120</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 5 26</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004304</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 6 50</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004227</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 7 35</name>
                        <postcode>BA133BN</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150004226</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT A 10</name>
                        <postcode>BA133BW</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150022638</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT B 10</name>
                        <postcode>BA133BW</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150022639</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT C 10</name>
                        <postcode>BA133BW</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150022640</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 1-9</name>
                        <postcode>BA133BW</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150022641</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <name>FLAT 2-9</name>
                        <postcode>BA133BW</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150022642</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT E 44</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005375</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 1 109</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005176</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 2 316</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005001</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 2 44</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005060</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 3 26</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005160</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 3 49</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005039</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 3A 181</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005430</addressID>
                     </address>
                  </potentialMatchedAddress>
                  <potentialMatchedAddress sourcedFrom=™MUL™>
                     <address>
                        <county>WILTS</county>
                        <district>CHAPMANSLADE</district>
                        <name>FLAT 5 11</name>
                        <postcode>BA134AJ</postcode>
                        <postTown>WESTBURY</postTown>
                        <street1>HIGH ST</street1>
                        <addressID>58150005477</addressID>
                     </address>
                  </potentialMatchedAddress>
               </suppliedAddressData>
            </primary>
         </soleSearch>
      </ns2:creditQuotationSearchResponse>
   </soapenv:Body>
</soapenv:Envelope>".Replace("™", "\"");


        #endregion



        public string HandleResponse(string request, ConfigureModel configuration)
        {
            configuration.Sleep();
            if (configuration.ThrowFaultException)
            {
                return FaultXML;
            }
            if (configuration.ThrowStackTrace)
            {
                throw new Exception("You are FooBared");
            }
            if (configuration.ReturnMultipleAddresses)
            {
                return multipleAddressXML;
            }
            return GoodResponse;
        }

        public bool Supports(Messages messageType)
        {
            return messageType == Messages.Equifax;
        }
    }
}