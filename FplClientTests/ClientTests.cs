 using System.Net;
 using System.Net.Http.Headers;
 using System.Net.Http.Json;
using FplClient;
using Moq;
using RichardSzalay.MockHttp;

namespace FplClientTests;

public class ClientTests
{
    private readonly Mock<IHttpClientFactory> clientFactory = new();
    private readonly MockHttpMessageHandler mockHttp = new();
    private readonly Client client;

    public ClientTests()
    {
        var hClient = new HttpClient();
        //hClient.BaseAddress = new Uri("https://fantasy.premierleague.com/");
        
        client = new Client(clientFactory.Object);

        // mockHttp.When("https://fantasy.premierleague.com/api/fixtures")
        //     .Respond(HttpStatusCode.OK, JsonContent.Create(Things.GameweeksResponse, MediaTypeHeaderValue.Parse("application/json")));
        
        //clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(mockHttp.ToHttpClient());
        clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(hClient);

        //client = new Client(new Httpclient
    }

    [Fact]
    public async Task TestGameweeks()
    {
        var actual = await client.Gameweeks(CancellationToken.None);
        Assert.NotEmpty(actual);
    }
}

public static class Things
{
    public const string GameweeksResponse
        = """
          [
            {
              "code": 2444470,
              "event": 1,
              "finished": true,
              "finished_provisional": true,
              "id": 1,
              "kickoff_time": "2024-08-16T19:00:00Z",
              "minutes": 90,
              "provisional_start_time": false,
              "started": true,
              "team_a": 9,
              "team_a_score": 0,
              "team_h": 14,
              "team_h_score": 1,
              "stats": [
                {
                  "identifier": "goals_scored",
                  "a": [],
                  "h": [
                    {
                      "value": 1,
                      "element": 389
                    }
                  ]
                },
                {
                  "identifier": "assists",
                  "a": [],
                  "h": [
                    {
                      "value": 1,
                      "element": 372
                    }
                  ]
                },
                {
                  "identifier": "own_goals",
                  "a": [],
                  "h": []
                },
                {
                  "identifier": "penalties_saved",
                  "a": [],
                  "h": []
                },
                {
                  "identifier": "penalties_missed",
                  "a": [],
                  "h": []
                },
                {
                  "identifier": "yellow_cards",
                  "a": [
                    {
                      "value": 1,
                      "element": 240
                    },
                    {
                      "value": 1,
                      "element": 241
                    },
                    {
                      "value": 1,
                      "element": 243
                    }
                  ],
                  "h": [
                    {
                      "value": 1,
                      "element": 377
                    },
                    {
                      "value": 1,
                      "element": 382
                    }
                  ]
                },
                {
                  "identifier": "red_cards",
                  "a": [],
                  "h": []
                },
                {
                  "identifier": "saves",
                  "a": [
                    {
                      "value": 4,
                      "element": 248
                    }
                  ],
                  "h": [
                    {
                      "value": 2,
                      "element": 383
                    }
                  ]
                },
                {
                  "identifier": "bonus",
                  "a": [],
                  "h": [
                    {
                      "value": 3,
                      "element": 389
                    },
                    {
                      "value": 2,
                      "element": 594
                    },
                    {
                      "value": 1,
                      "element": 369
                    },
                    {
                      "value": 1,
                      "element": 380
                    }
                  ]
                },
                {
                  "identifier": "bps",
                  "a": [
                    {
                      "value": 16,
                      "element": 249
                    },
                    {
                      "value": 15,
                      "element": 240
                    },
                    {
                      "value": 15,
                      "element": 255
                    },
                    {
                      "value": 13,
                      "element": 245
                    },
                    {
                      "value": 12,
                      "element": 248
                    },
                    {
                      "value": 11,
                      "element": 19
                    },
                    {
                      "value": 10,
                      "element": 251
                    },
                    {
                      "value": 7,
                      "element": 257
                    },
                    {
                      "value": 5,
                      "element": 239
                    },
                    {
                      "value": 5,
                      "element": 241
                    },
                    {
                      "value": 5,
                      "element": 247
                    },
                    {
                      "value": 4,
                      "element": 254
                    },
                    {
                      "value": 4,
                      "element": 259
                    },
                    {
                      "value": 3,
                      "element": 252
                    },
                    {
                      "value": 2,
                      "element": 243
                    },
                    {
                      "value": 2,
                      "element": 256
                    }
                  ],
                  "h": [
                    {
                      "value": 33,
                      "element": 389
                    },
                    {
                      "value": 32,
                      "element": 594
                    },
                    {
                      "value": 26,
                      "element": 369
                    },
                    {
                      "value": 26,
                      "element": 380
                    },
                    {
                      "value": 25,
                      "element": 383
                    },
                    {
                      "value": 22,
                      "element": 377
                    },
                    {
                      "value": 21,
                      "element": 378
                    },
                    {
                      "value": 19,
                      "element": 368
                    },
                    {
                      "value": 11,
                      "element": 364
                    },
                    {
                      "value": 11,
                      "element": 372
                    },
                    {
                      "value": 10,
                      "element": 366
                    },
                    {
                      "value": 5,
                      "element": 385
                    },
                    {
                      "value": 3,
                      "element": 381
                    },
                    {
                      "value": 3,
                      "element": 593
                    },
                    {
                      "value": 2,
                      "element": 371
                    },
                    {
                      "value": -1,
                      "element": 382
                    }
                  ]
                },
                {
                  "identifier": "mng_underdog_win",
                  "a": [],
                  "h": []
                },
                {
                  "identifier": "mng_underdog_draw",
                  "a": [],
                  "h": []
                }
              ],
              "team_h_difficulty": 3,
              "team_a_difficulty": 3,
              "pulse_id": 115827
            }
          ]
          """;
}