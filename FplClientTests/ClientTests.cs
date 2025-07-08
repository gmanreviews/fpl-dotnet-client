using System.Net;
using System.Net.Http.Json;
using FplClient;
using Moq;
using RichardSzalay.MockHttp;

namespace FplClientTests;

public class ClientTests
{
    private readonly Mock<IHttpClientFactory> clientFactory = new();

    private readonly MockHttpMessageHandler mockHttp = new();

    //private readonly MockedRequest mockRequest; // = new();
    private readonly Client client;

    public ClientTests()
    {
        client = new Client(clientFactory.Object);

        mockHttp.When("https://fantasy.premierleague.com/api/gameweeks")
            .Respond(HttpStatusCode.OK, JsonContent.Create(Things.GameweekResponse));

        clientFactory.Setup(c => c.CreateClient(It.IsAny<string>())).Returns(mockHttp.ToHttpClient());
    }

    [Fact]
    public async Task TestGameweeks()
    {
        var actual = await client.Gameweeks(CancellationToken.None);
        mockHttp.VerifyNoOutstandingExpectation();
    }
}

public class Things
{
    public const string GameweekResponse
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
            },
            {
              "code": 2444473,
              "event": 1,
              "finished": true,
              "finished_provisional": true,
              "id": 4,
              "kickoff_time": "2024-08-17T11:30:00Z",
              "minutes": 90,
              "provisional_start_time": false,
              "started": true,
              "team_a": 12,
              "team_a_score": 2,
              "team_h": 10,
              "team_h_score": 0,
              "stats": [
                {
                  "identifier": "goals_scored",
                  "a": [
                    {
                      "value": 1,
                      "element": 317
                    },
                    {
                      "value": 1,
                      "element": 328
                    }
                  ],
                  "h": []
                },
                {
                  "identifier": "assists",
                  "a": [
                    {
                      "value": 1,
                      "element": 328
                    },
                    {
                      "value": 1,
                      "element": 336
                    }
                  ],
                  "h": []
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
                      "element": 321
                    }
                  ],
                  "h": [
                    {
                      "value": 1,
                      "element": 264
                    },
                    {
                      "value": 1,
                      "element": 274
                    },
                    {
                      "value": 1,
                      "element": 284
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
                      "value": 2,
                      "element": 310
                    }
                  ],
                  "h": [
                    {
                      "value": 3,
                      "element": 283
                    }
                  ]
                },
                {
                  "identifier": "bonus",
                  "a": [
                    {
                      "value": 3,
                      "element": 328
                    },
                    {
                      "value": 2,
                      "element": 311
                    },
                    {
                      "value": 1,
                      "element": 310
                    },
                    {
                      "value": 1,
                      "element": 336
                    }
                  ],
                  "h": []
                },
                {
                  "identifier": "bps",
                  "a": [
                    {
                      "value": 38,
                      "element": 328
                    },
                    {
                      "value": 31,
                      "element": 311
                    },
                    {
                      "value": 28,
                      "element": 310
                    },
                    {
                      "value": 28,
                      "element": 336
                    },
                    {
                      "value": 24,
                      "element": 317
                    },
                    {
                      "value": 24,
                      "element": 335
                    },
                    {
                      "value": 24,
                      "element": 339
                    },
                    {
                      "value": 13,
                      "element": 327
                    },
                    {
                      "value": 12,
                      "element": 326
                    },
                    {
                      "value": 7,
                      "element": 329
                    },
                    {
                      "value": 7,
                      "element": 333
                    },
                    {
                      "value": 6,
                      "element": 323
                    },
                    {
                      "value": 3,
                      "element": 313
                    },
                    {
                      "value": 3,
                      "element": 337
                    },
                    {
                      "value": -1,
                      "element": 321
                    }
                  ],
                  "h": [
                    {
                      "value": 14,
                      "element": 278
                    },
                    {
                      "value": 12,
                      "element": 265
                    },
                    {
                      "value": 12,
                      "element": 270
                    },
                    {
                      "value": 11,
                      "element": 274
                    },
                    {
                      "value": 9,
                      "element": 283
                    },
                    {
                      "value": 8,
                      "element": 268
                    },
                    {
                      "value": 8,
                      "element": 277
                    },
                    {
                      "value": 7,
                      "element": 284
                    },
                    {
                      "value": 3,
                      "element": 281
                    },
                    {
                      "value": 2,
                      "element": 260
                    },
                    {
                      "value": 2,
                      "element": 611
                    },
                    {
                      "value": 1,
                      "element": 271
                    },
                    {
                      "value": 1,
                      "element": 282
                    },
                    {
                      "value": -1,
                      "element": 267
                    },
                    {
                      "value": -2,
                      "element": 264
                    },
                    {
                      "value": -5,
                      "element": 275
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
              "team_h_difficulty": 5,
              "team_a_difficulty": 2,
              "pulse_id": 115830
            }
          ]
          """;
}